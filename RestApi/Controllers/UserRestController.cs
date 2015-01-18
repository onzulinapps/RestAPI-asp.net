using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestApi.Models;
using System.Data.Entity;
using RestApi.DAL;
using Newtonsoft.Json;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace RestApi.Controllers
{
    public class UserRestController : Controller
    {
        private MyDbContext db = new MyDbContext();
        // GET: UserRest
        [HttpGet]
        public List<Usuarios> index()
        {
            //aqui recuperaremos los usuarios 
            
            List<Usuarios> usuarios = new List<Usuarios>();
            usuarios = db.Usuarios.ToList();
            
            string usuariosList = usuarios.ToString();
            JsonResult jsonResult = new JsonResult();
            jsonResult.Data = usuarios;
            //return jsonResult(jsonResult.Data, JsonRequestBehavior.AllowGet);
            
            return usuarios;
            
        }

        [HttpGet]
        public JsonResult Usuarios()
        {
            return Json(this.index(),
                        JsonRequestBehavior.AllowGet);
        }
        // GET: UserRest/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserRest/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserRest/Create
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

        // GET: UserRest/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserRest/Edit/5
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

        // GET: UserRest/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserRest/Delete/5
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
