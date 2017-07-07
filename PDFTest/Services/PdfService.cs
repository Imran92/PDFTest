using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RazorEngine;
using RazorEngine.Templating;
using NReco;
using System.IO;
using PDFTest.ViewModels;
using RazorEngine.Configuration;
using System.Web.Mvc;
using System.Text;
using System.Web.UI;

namespace PDFTest.Services
{
    public class PdfService
    {
        
        public PdfService()
        {
            
        }
        public void GeneratePdf(ControllerContext context,PdfSubmitModel model)
        {
            string templateFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Views");
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            //var templateString = File.ReadAllText(templateFolderPath + "/Home/FormSubmit.cshtml");
            model.filePath = AppDomain.CurrentDomain.BaseDirectory;
            var parsedResult = context.RenderPartialToString("FormSubmit", model);
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "/Home/mypdffile.html", parsedResult);
            //var pdfBytes = htmlToPdf.GeneratePdf(parsedResult);
            var pdfBytes = htmlToPdf.GeneratePdfFromFile(AppDomain.CurrentDomain.BaseDirectory + "Home/mypdffile.html", null);
            var templateString = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Home/mypdffile.html");
            ByteArrayToFile(AppDomain.CurrentDomain.BaseDirectory + "mypdffile3.pdf", PdfSharpConvert(templateString));
        }
        public bool ByteArrayToFile(string fileName, byte[] byteArray)
        {
            try
            {
                using (var fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(byteArray, 0, byteArray.Length);
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
                return false;
            }
        }
        public static Byte[] PdfSharpConvert(String html)
        {
            Byte[] res = null;
            using (MemoryStream ms = new MemoryStream())
            {
                var pdf = TheArtOfDev.HtmlRenderer.PdfSharp.PdfGenerator.GeneratePdf(html, PdfSharp.PageSize.A4);
                pdf.Save(ms);
                res = ms.ToArray();
            }
            return res;
        }
    }
}