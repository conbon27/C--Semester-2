namespace OrderSummary
{
    partial class OrderSummary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.view = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.average = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.oidBox = new System.Windows.Forms.TextBox();
            this.priceBox = new System.Windows.Forms.TextBox();
            this.cBox = new System.Windows.Forms.TextBox();
            this.Tbox = new System.Windows.Forms.TextBox();
            this.oid = new System.Windows.Forms.Label();
            this.cid = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.terms = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.SystemColors.Desktop;
            this.view.ForeColor = System.Drawing.SystemColors.Control;
            this.view.Location = new System.Drawing.Point(123, 357);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(170, 90);
            this.view.TabIndex = 0;
            this.view.Text = "View Data";
            this.view.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.view.UseVisualStyleBackColor = false;
            this.view.Click += new System.EventHandler(this.btn_View);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(362, 357);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(159, 90);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.btn_Add);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(583, 357);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(165, 90);
            this.edit.TabIndex = 2;
            this.edit.Text = "Update";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.btn_Edit);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(825, 357);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(153, 90);
            this.delete.TabIndex = 3;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.btn_Delete);
            // 
            // average
            // 
            this.average.BackColor = System.Drawing.SystemColors.Highlight;
            this.average.Location = new System.Drawing.Point(1054, 357);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(170, 85);
            this.average.TabIndex = 4;
            this.average.Text = "Average";
            this.average.UseVisualStyleBackColor = false;
            this.average.Click += new System.EventHandler(this.btn_Average);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(125, 507);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1101, 220);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.view_Data);
            // 
            // oidBox
            // 
            this.oidBox.Location = new System.Drawing.Point(362, 80);
            this.oidBox.Name = "oidBox";
            this.oidBox.Size = new System.Drawing.Size(159, 38);
            this.oidBox.TabIndex = 6;
            // 
            // priceBox
            // 
            this.priceBox.Location = new System.Drawing.Point(950, 80);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(274, 38);
            this.priceBox.TabIndex = 7;
            // 
            // cBox
            // 
            this.cBox.Location = new System.Drawing.Point(362, 208);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(159, 38);
            this.cBox.TabIndex = 8;
            // 
            // Tbox
            // 
            this.Tbox.Location = new System.Drawing.Point(950, 208);
            this.Tbox.Name = "Tbox";
            this.Tbox.Size = new System.Drawing.Size(274, 38);
            this.Tbox.TabIndex = 9;
            // 
            // oid
            // 
            this.oid.AutoSize = true;
            this.oid.Location = new System.Drawing.Point(113, 85);
            this.oid.Name = "oid";
            this.oid.Size = new System.Drawing.Size(64, 32);
            this.oid.TabIndex = 10;
            this.oid.Text = "OID";
            // 
            // cid
            // 
            this.cid.AutoSize = true;
            this.cid.Location = new System.Drawing.Point(119, 208);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(171, 32);
            this.cid.TabIndex = 11;
            this.cid.Text = "Customer ID";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(766, 86);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(80, 32);
            this.price.TabIndex = 12;
            this.price.Text = "Price";
            // 
            // terms
            // 
            this.terms.AutoSize = true;
            this.terms.Location = new System.Drawing.Point(766, 214);
            this.terms.Name = "terms";
            this.terms.Size = new System.Drawing.Size(94, 32);
            this.terms.TabIndex = 13;
            this.terms.Text = "Terms";
            // 
            // OrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1429, 832);
            this.Controls.Add(this.terms);
            this.Controls.Add(this.price);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.oid);
            this.Controls.Add(this.Tbox);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.oidBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.average);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.view);
            this.Name = "OrderSummary";
            this.Text = "Order Summary";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button average;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox oidBox;
        private System.Windows.Forms.TextBox priceBox;
        private System.Windows.Forms.TextBox cBox;
        private System.Windows.Forms.TextBox Tbox;
        private System.Windows.Forms.Label oid;
        private System.Windows.Forms.Label cid;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label terms;
    }
}

