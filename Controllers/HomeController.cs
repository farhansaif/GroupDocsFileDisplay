using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.Mvc;
using Groupdocs.Web.UI;

namespace GroupDocsFileDisplay.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.FileName = null;
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            string fileName = "";

            try
            {
                if (file != null && file.ContentLength > 0)
                {
                    //Get the file name of the file to be Uploaded
                    String FileExtension = Path.GetExtension(file.FileName);

                    //Get the file extension of the file to be uploaded
                    fileName = Path.GetFileName(file.FileName);

                    //Get the RootStoragePath value using RootPathFinder class of namespace Groupdocs.Web.UI. The RootStoragePath is set in the Global.asax
                    RootPathFinder rpf = new RootPathFinder();
                    string rootDirectory = rpf.GetRootStoragePath();

                    var FilePath = rootDirectory + fileName;

                    //Save the file
                    file.SaveAs(FilePath);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            //Pass the FileName to View for display in the Div 
            ViewBag.FileName = fileName;
            return View();
        }
    }
}
