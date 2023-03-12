using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskManager.Models;

namespace TaskManager.Controllers
{
	public class UsersController : Controller
	{
		public IActionResult NewUser()
		{
			return View();
		}
	}
}
