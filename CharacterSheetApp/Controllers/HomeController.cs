﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace CharacterSheetApp.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var name = "Shield";
			return View("Index", name);
		}
	}
}