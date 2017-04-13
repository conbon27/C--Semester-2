using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingArticleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // reads current contents of the file to the console - if file is indeed there (which it is)
            if (File.Exists(@"C:\Users\aconw\Documents\Visual Studio 2015\Projects\FileHandlingArticleApp\FileHandlingArticleApp\fileio.txt"))
            {
                string contents = File.ReadAllText(@"C: \Users\aconw\Documents\Visual Studio 2015\Projects\FileHandlingArticleApp\FileHandlingArticleApp\fileio.txt");
                Console.WriteLine("Beginning data in this file: ");
                Console.WriteLine(contents);
                Console.WriteLine("Press the any key.");
                Console.ReadKey();
            }
            // writes to that same file
            Console.WriteLine("Please enter data to be added to this file:");
            Console.WriteLine("Type save & press return to save");
            string addContents = Console.ReadLine();
            while (addContents != "save")
            {   
                File.AppendAllText(@"C: \Users\aconw\Documents\Visual Studio 2015\Projects\FileHandlingArticleApp\FileHandlingArticleApp\fileio.txt", addContents);
                // to replace contents, use:
                // File.WriteAllText(@"C: \Users\aconw\Documents\Visual Studio 2015\Projects\FileHandlingArticleApp\FileHandlingArticleApp\fileio.txt", addContents);
                addContents = Console.ReadLine();
            }
        } // closes main
    } // closes class
} // ends namespace
