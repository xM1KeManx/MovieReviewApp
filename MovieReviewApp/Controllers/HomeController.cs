using Microsoft.AspNetCore.Mvc;
using MovieReviewApp.Services;

namespace MovieReviewApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ReviewService _service;
        public HomeController(ReviewService service) => _service = service;

        public IActionResult Index()
        {
            var model = _service.GetAll();
            return View(model);
        }
    }
}
