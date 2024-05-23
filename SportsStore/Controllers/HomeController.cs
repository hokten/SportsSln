using Microsoft.AspNetCore.Mvc;
namespace SportsStore.Controllers {
	public class HomeController: Controller {
		private readonly StoreDbContext _context;
		
		public HomeController(StoreDbContext context)
		{
			_context = context;
		}		
		
		public IActionResult Index() {
			return View();
		}
	}
}

