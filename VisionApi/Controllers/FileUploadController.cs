using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VisionApi.Controllers
{
    public class FileUploadController : Controller
    {
        public ActionResult FileUpload(HttpPostedFileBase file)
        {
            if (file != null)
            {
                string pic = System.IO.Path.GetFileName(file.FileName);
                string path = System.IO.Path.Combine(
               Server.MapPath("~/Views/FileUpload/Images/"), pic);
              
                // file is uploaded
                file.SaveAs(path);

                // save the image path path to the database or you can send image 
                // directly to database
                // in-case if you want to store byte[] ie. for DB
                using (MemoryStream ms = new MemoryStream())
                {
                    file.InputStream.CopyTo(ms);
                    byte[] array = ms.GetBuffer();
                }

            }
            // after successfully uploading redirect the user
            
           // return RedirectToAction("actionname", "controller name");
           // return RedirectToAction("FileUpload", "FileUpload");
            return View();
        }
        // GET: FileUpload
        public ActionResult Index()
        {
            return View();
        }

        // GET: FileUpload/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FileUpload/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FileUpload/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FileUpload/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FileUpload/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FileUpload/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FileUpload/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
