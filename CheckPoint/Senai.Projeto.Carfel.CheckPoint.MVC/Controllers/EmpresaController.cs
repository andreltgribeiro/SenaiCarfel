using Microsoft.AspNetCore.Mvc;

namespace Senai.Projeto.Carfel.CheckPoint.MVC.Controllers
{
    public class EmpresaController : Controller
    {
        [HttpGet]
        public IActionResult Index(){
            return View();
        }
        
    }
}