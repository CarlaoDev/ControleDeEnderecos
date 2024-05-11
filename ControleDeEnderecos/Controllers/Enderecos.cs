using Microsoft.AspNetCore.Mvc;

namespace ControleDeEnderecos.Controllers
{
    public class Enderecos : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
