using Microsoft.AspNetCore.Mvc;

namespace Senai.Projeto.Carfel.CheckPoint.MVC.Controllers
{
    public class FaqController : Controller
    {
        [HttpGet]
        public IActionResult Index(){
            return View();
        }
    }
}