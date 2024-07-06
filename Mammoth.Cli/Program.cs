using System;

namespace Mammoth.Cli
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var result = new DocumentConverter().ConvertToHtml(@"C:\Users\rahulkumar.yadav\OneDrive - Audree Infotech Pvt Ltd\Desktop\Mammoth.docx");
            Console.WriteLine(result.Value);
        }
    }
}
