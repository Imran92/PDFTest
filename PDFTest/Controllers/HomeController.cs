using PDFTest.Services;
using PDFTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;


namespace PDFTest.Controllers
{
    public class HomeController : Controller
    {
        PdfService _pdfService;
        public HomeController()
        {
            _pdfService = new PdfService();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult GetForm()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ViewForms(PdfSubmitModel model)
        {
            return View(model);
        }
        public ActionResult FormSubmit(PdfSubmitModel model)
        {
            string filepath = _pdfService.GeneratePdf(ControllerContext,model);
            string filename = Path.GetFileName(filepath);
            byte[] filedata = System.IO.File.ReadAllBytes(filepath);
            string contentType = MimeMapping.GetMimeMapping(filepath);
            var cd = new System.Net.Mime.ContentDisposition
            {
                FileName = filename,
                Inline = true,
            };

            Response.AppendHeader("Content-Disposition", cd.ToString());

            return File(filedata, contentType);
        }
    }
}