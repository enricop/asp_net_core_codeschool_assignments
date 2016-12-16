using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using CharacterSheetApp.Models;

namespace CharacterSheetApp.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var model = new CharacterSheetApp.Models.Equipment ();
			model.Name = "Shield";

			return View("Index", model);
		}
	}
}