﻿using PDFTest.Services;
using PDFTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rotativa;
using System.IO;
using Rotativa.Options;

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
            _pdfService.GeneratePdf(ControllerContext,model);
            return RedirectToAction("ViewForms");
            
        }
    }
}