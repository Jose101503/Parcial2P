using Microsoft.AspNetCore.Mvc;
using Parcial2P.Models;
using System.Diagnostics;

namespace Parcial2P.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Procesar(int Monto)
        {


            {
                
                    if (( Monto % 5) == 0)
                    {
                    return Redirect("/Home/Mostrar");
                }
                else
                    return Redirect("/Home/Error");
            }
        }
        public IActionResult Mostrar()
        {
            return  View();
        }
    }
}