using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pdf_To_HTML
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Property
            //Put your pdf file path
            string pathToPdf = @"C:/Users/dhire/Downloads/Compressed/Convert PDF file to HTML file in C# - Step by Step/table.pdf";
            string pathToHtml = Path.ChangeExtension(pathToPdf, ".htm");

            SautinSoft.PdfFocus f = new SautinSoft.PdfFocus();
            #endregion

            #region Declaration
            f.HtmlOptions.IncludeImageInHtml = true;
            f.HtmlOptions.Title = "Simple text";

            f.OpenPdf(pathToPdf);

            if (f.PageCount > 0)
            {
                int result = f.ToHtml(pathToHtml);

                if (result == 0)
                {
                    System.Diagnostics.Process.Start(pathToHtml);
                }
            }

            #endregion
        }
    }
}
