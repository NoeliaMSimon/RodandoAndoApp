using Microsoft.AspNetCore.Mvc;

namespace RodandoAndoApp.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

    }
}
