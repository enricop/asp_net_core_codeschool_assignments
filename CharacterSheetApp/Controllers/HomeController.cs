using System;
using System.Web.Mvc;
using CharacterSheetApp.Models;

namespace CharacterSheetApp.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()	
		{
			return View(Equipment.GetAll());
		}

		public ActionResult Create(string EquipmentName)
		{
			Equipment.Create(EquipmentName);
			return RedirectToAction("Index", "Home");
		}
	}
}