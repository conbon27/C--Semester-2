using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace ProjSchema
{
    class CSV2XML
    {
        public static void Main(string[] args)
        {
            // reads current contents of the file to the console - if file is indeed there (which it is)
            if (File.Exists(@"C: \Users\aconw\Downloads\CSV_TidePredictionTester.csv"))
            {
                var lines = File.ReadAllLines(@"C: \Users\aconw\Downloads\CSV_TidePredictionTester.csv");
                // reads all line from particular csv file location
                string[] headers = lines[0].Split(',').Select(x => x.Trim('\"')).ToArray();
                // designates first line as headers - split with commas

                var xml = new XElement("TopElement",
                   lines.Where((line, index) => index > 0).Select(line
                   => new XElement("Item",
                      line.Split(',').Select((column, index)
                 // => new XElement("Column" + index, column)))));
                 //gives generic naming to elements
                 => new XElement(headers[index], column)))));
                // sets the headers as the element names

                xml.Save(@"C:\Users\aconw\Downloads\xmlout_TidePrediction.xml");
                // outputs xml to new file location
            }else
            {
                Console.WriteLine("No files found, please check code.");
                Console.ReadKey();
            }
        } // closes main
    } // closes class
} // ends namespace

