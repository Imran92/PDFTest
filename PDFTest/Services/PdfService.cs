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
using Pechkin;


using IronPdf;


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
            //var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            //var templateString = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "/Home/mypdffile45.html");
            //model.filePath = AppDomain.CurrentDomain.BaseDirectory;
            var parsedResult = context.RenderPartialToString("ViewForms", model);
            //System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "Home/mypdffile99.html", parsedResult);
            //htmlToPdf.Quiet = false;
            //htmlToPdf.LogReceived += (sender, e) => {
            //    Console.WriteLine("WkHtmlToPdf Log: {0}", e.Data);
            //    System.IO.File.AppendAllText(AppDomain.CurrentDomain.BaseDirectory + "Home/hudai.txt", "WkHtmlToPdf Log: "+ e.Data);
            //};
            //var pdfBytes = htmlToPdf.GeneratePdf(templateString, null);
            //var pdfBytes = htmlToPdf.GeneratePdfFromFile(AppDomain.CurrentDomain.BaseDirectory + "Home/mypdffile9.html", null);
            //var templateString = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "Home\\mypdffile.html");
            //var pdfBytes = PdfSharpConvert(templateString);
            //HtmlToPdf converter = new HtmlToPdf();

            //// create a new pdf document converting an url 
            //PdfDocument doc = converter.ConvertHtmlString(parsedResult);

            //// save pdf document 
            //byte[] pdf = doc.Save();

            //// close pdf document 
            //doc.Close();
            //HtmlToPdf HtmlToPdf = new IronPdf.HtmlToPdf();
            //PdfDocument PDF = HtmlToPdf.RenderUrlAsPdf(AppDomain.CurrentDomain.BaseDirectory + "Home/mypdffile99.html");
            //PDF.SaveAs(AppDomain.CurrentDomain.BaseDirectory + "Home/mypdffile99.pdf");
            var pdfBytes = new SimplePechkin(new GlobalConfig()).Convert(parsedResult);
            ByteArrayToFile(AppDomain.CurrentDomain.BaseDirectory + "mypdffile556.pdf", pdfBytes);
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