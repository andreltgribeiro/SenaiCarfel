using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Projeto.Carfel.CheckPoint.MVC.Models;
using Senai.Projeto.Carfel.CheckPoint.MVC.Repositorios;
using Senai.Projeto.Carfel.CheckPoint.MVC.Interfaces;
using System.Linq;

namespace Senai.Projeto.Carfel.CheckPoint.MVC.Controllers
{
    public class ComentariosController : Controller
    {
        public IComentario ComentarioRepositorio {get; set;}

        public ComentariosController(){
            ComentarioRepositorio = new ComentarioRepositorioSerializacao();
        }
        [HttpGet]
        public IActionResult Index(){

            if(HttpContext.Session.GetString("tipoUsuario") == "1")
                ViewData["Comentarios"] = ComentarioRepositorio.Listar();
            else
                ViewData["Comentarios"] = ComentarioRepositorio.Listar().Where(x => x.Aprovado);

            return View();
        }
        
        [HttpPost]
        public IActionResult Index(IFormCollection form){

            ComentarioModel comentarioModel = new ComentarioModel(texto: form["texto"],aprovado: false, nomeUsuario: HttpContext.Session.GetString("nomeUsuario"));

            ComentarioRepositorio.Criar(comentarioModel);

            if(HttpContext.Session.GetString("tipoUsuario") == "1")
                ViewData["Comentarios"] = ComentarioRepositorio.Listar();
            else
                ViewData["Comentarios"] = ComentarioRepositorio.Listar().Where(x => x.Aprovado);
                
                TempData["Mensagem"] = "Comentário enviado para aprovação dos administradores";

            return View();
        }
        [HttpGet]
        public IActionResult AprovarComentarios(){

                ViewData["Comentarios"] = ComentarioRepositorio.Listar();
           
            return View();
        }

        [HttpGet]
        public IActionResult ComentarioDeslogado (){


            if(HttpContext.Session.GetString("tipoUsuario")== "1")
                ViewData["Comentarios"] = ComentarioRepositorio.Listar();
            else
                ViewData["Comentarios"] = ComentarioRepositorio.Listar().Where(x => x.Aprovado);

            return View();
        }
        [HttpGet]
        public IActionResult Excluir(int id)
        {
            ComentarioRepositorio.Excluir(id);

            TempData["Mensagem"] = "Comentario excluído";

            return RedirectToAction("AprovarComentarios");
        }

        [HttpGet]
        public IActionResult Aprovar(int id)
        {
            ComentarioRepositorio.Aprovar(id);

            TempData["Mensagem"] = "Comentario Aprovado";

            return RedirectToAction("AprovarComentarios");

        }
    }
}