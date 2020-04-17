using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DesafioTiago.Models;
namespace DesafioTiago.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            ViewBag.EstadosList = new SelectList(
                new Estados().ListarEstados(),
                "ID",
                "Nome",
                "Sigla"
                    );

            ViewBag.CidadesList = new SelectList(new Cidades().ListarCidades(true),
                "ID",                
                "Nome");

            return View();
        }
        
        public JsonResult Cidades(int ?id)
        {
            id = id == null ? 1 : id;
            Cidades ListaDeCidades = new Cidades();

            return Json(ListaDeCidades.ListarCidades(false).Where(cidade=>cidade.IDEstado == id), JsonRequestBehavior.AllowGet);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}