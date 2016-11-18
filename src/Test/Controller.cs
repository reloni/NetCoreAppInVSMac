using System;
using Microsoft.AspNetCore.Mvc;

namespace Test
{
	public class HomeController : Controller
	{
		public JsonResult Time()
		{
			return Json(new { Type = "Time", Value = DateTime.Now.ToString("hh:mm:ss tt") });
		}

		public JsonResult Year()
		{
			return Json(new { Type = "Year", Value = DateTime.Now.Year });
		}
	}
}
