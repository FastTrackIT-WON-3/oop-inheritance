using System;

namespace OopInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelFile paycheck = new ExcelFile("Paycheck", "Excel 2019");
            // general functionality available for all files
            paycheck.Open();
            // specific functionality for Excel files
            paycheck.PerformCalculation("A = B + C");

            PdfFile book = new PdfFile("Book ABC", false);
            // general functionality available for all files
            book.Open();
            // specific functionality for Pdf files
            book.AttemptEdit();

            Console.WriteLine("-----------------------------------");

            OpenFiles(paycheck, book);
        }

        private static void OpenFiles(params File[] files)
        {
            foreach (File file in files)
            {
                file.Open();
            }
        }
    }
}
