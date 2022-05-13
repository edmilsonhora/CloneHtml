using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Clone.Models;

namespace Web_Clone.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: Categorias
        public ActionResult Index()
        {
            var r = new CategoriaRepository().GetAll();
            return View(r);
        }

        [HttpGet]
        public JsonResult GetCategories()
        {
            var r = new CategoriaRepository().GetAll();
            return Json(r, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetProducts(int id)
        {
            var r = new ProdutoRepository().GetBy(id);
            return Json(r, JsonRequestBehavior.AllowGet);
        }
    }
}