using Microsoft.AspNetCore.Mvc;
namespace Senai.Projeto.Carfel.CheckPoint.MVC.Controllers
{
    public class HomeADMController : Controller
    {
        [HttpGet]
        public IActionResult IndexADM(){
            return View();
        }
    }
}