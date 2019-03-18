using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP_Music.Controllers
{
    public class UtilisateurController : Controller
    {
        // GET: Utilisateur
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Menu()
        {
            ViewBag.Message = "Menu Utilisateur";
            
            return View();
        }
		public ActionResult Changermotdepasse()
		{
			ViewBag.Message = "Menu Changement de mot de passe";

			return View();
		}
	}
}