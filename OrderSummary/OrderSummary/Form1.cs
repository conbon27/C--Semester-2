using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OrderSummary
{
    public partial class OrderSummary : Form
    {
        // creates connection variable
        readonly MySqlConnection _conn = new MySqlConnection("Server = danu6.it.nuigalway.ie; Database = mydb2463; Uid = mydb2463ca; Pwd = mi3tax");
        int _id = 0;
        // initial state set-up
        public OrderSummary()
        {
            InitializeComponent();
            Display();
        }
        // add data to DB table
        private void btn_Add(object sender, EventArgs e)
        {
            if (oidBox.Text != "" && cBox.Text != "" && priceBox.Text != "" && Tbox.Text != "")
            {
                var cmd = new MySqlCommand("INSERT INTO OrderTab(OID,CustomerID, OrderPrice, Terms) VALUES(@OID,@CustomerID, @OrderPrice, @Terms)", _conn);
                _conn.Open();
                cmd.Parameters.AddWithValue("@OID", oidBox.Text);
                cmd.Parameters.AddWithValue("@CustomerID", cBox.Text);
                cmd.Parameters.AddWithValue("@OrderPrice", priceBox.Text);
                cmd.Parameters.AddWithValue("@Terms", Tbox.Text);
                cmd.ExecuteNonQuery();
                _conn.Close();
                MessageBox.Show(@"Record Inserted Successfully");
                Display();
                Clear();
            }
            else
            {
                MessageBox.Show(@"Insufficient information - please check again.");
            }
        }
        // view data on table in form
        private void btn_View(object sender, EventArgs e)
        {
            _conn.Open();
            var dt = new DataTable();
            var ad = new MySqlDataAdapter("SELECT * FROM OrderTab;", _conn);
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            _conn.Close();
        }
        // edit data in DB table
        private void btn_Edit(object sender, EventArgs e)
        {
            if (oidBox.Text != "" && cBox.Text != "" && priceBox.Text != "" && Tbox.Text != "")
            {
                var cmd = new MySqlCommand("UPDATE OrderTab set OID=@OID,CustomerID=@CustomerID, OrderPrice=@OrderPrice, Terms=@Terms where OID=@OID", _conn);
                _conn.Open();
                cmd.Parameters.AddWithValue("@OID", oidBox.Text);
                cmd.Parameters.AddWithValue("@CustomerID", cBox.Text);
                cmd.Parameters.AddWithValue("@OrderPrice", priceBox.Text);
                cmd.Parameters.AddWithValue("@Terms", Tbox.Text);
                cmd.ExecuteNonQuery();
                // outputs message if successful
                MessageBox.Show(@"Record Updated.");
                _conn.Close();
                Display();
                Clear();
            }
            else
            {
                MessageBox.Show(@"Nothing selected, please select something.");
            }
        }
        // delete data from DB table
        private void btn_Delete(object sender, EventArgs e)
        {
            if (_id != 0)
            {
                var cmd = new MySqlCommand("DELETE OrderTab where OID=@id", _conn);
                _conn.Open();
                cmd.Parameters.AddWithValue("@id", _id);
                cmd.ExecuteNonQuery();
                _conn.Close();
                // outputs message if successfully deleted
                MessageBox.Show(@"Deleted.");
                Display();
                Clear();
            }
            else
            {
                MessageBox.Show(@"Nothing selected, please select something.");
            }
        }
        // average order
        private void btn_Average(object sender, EventArgs e)
        {
            if (oidBox.Text != "" && cBox.Text != "" && priceBox.Text != "" && Tbox.Text != "")
            {
                var cmd = new MySqlCommand("SELECT AVG(OrderPrice) FROM OrderTab;", _conn);
                _conn.Open();
                var avg = cmd.ExecuteScalar();
                // outputs message if successful
                MessageBox.Show(@"Average Order Price: " + avg.ToString());
                _conn.Close();
                Display();
                Clear();
            }
            else
            {
                MessageBox.Show(@"No orders to average.");
            }
        }
        // Clears typed data to return state to 0.  
        private void Clear()
        {
            _id = 0;
            oidBox.Text = "";
            cBox.Text = "";
            priceBox.Text = "";
            Tbox.Text = "";
        }
        // outputs data in DataGrid form field
        private void Display()
        {
            _conn.Open();
            var dt = new DataTable();
            var ad = new MySqlDataAdapter("SELECT * FROM OrderTab;", _conn);
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            _conn.Close();
        }
        private void view_Data(object sender, DataGridViewCellMouseEventArgs e)
        {
            oidBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            cBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            priceBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            Tbox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
