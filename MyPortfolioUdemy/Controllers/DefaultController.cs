using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioUdemy.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
