using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Projeto.Carfel.CheckPoint.MVC.Models;
using Senai.Projeto.Carfel.CheckPoint.MVC.Repositorios;
using Senai.Projeto.Carfel.CheckPoint.MVC.Interfaces;

namespace Senai.Projeto.Carfel.CheckPoint.MVC.Controllers
{
    public class ComentariosController : Controller
    {
        [HttpGet]
        public IActionResult Index(){
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();

            if(HttpContext.Session.GetString("tipoUsuario") == "1")
                ViewData["Comentarios"] = comentarioRepositorio.Listar();
            else
                ViewData["Comentarios"] = comentarioRepositorio.ListarEMostrar();

            return View();
        }
        
        [HttpPost]
        public IActionResult Index(IFormCollection form){

            ComentarioModel comentarioModel = new ComentarioModel(texto: form["texto"],aprovado: false, nomeUsuario: HttpContext.Session.GetString("nomeUsuario"));

            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            comentarioRepositorio.Criar(comentarioModel);

            if(HttpContext.Session.GetString("tipoUsuario") == "1")
                ViewData["Comentarios"] = comentarioRepositorio.Listar();
            else
                ViewData["Comentarios"] = comentarioRepositorio.ListarEMostrar();
                
                TempData["Mensagem"] = "Comentário enviado para aprovação dos administradores";

            return View();
        }
        [HttpGet]
        public IActionResult AprovarComentarios(){
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
                ViewData["Comentarios"] = comentarioRepositorio.Listar();
           
            return View();
        }

        [HttpGet]
        public IActionResult ListarEMostrar(){
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            if(HttpContext.Session.GetString("tipoUsuario") == "1")
                ViewData["Comentarios"] = comentarioRepositorio.Listar();
            else
                ViewData["Comentarios"] = comentarioRepositorio.ListarEMostrar();
            
            return View();
        }

        [HttpGet]
        public IActionResult ComentarioDeslogado (){
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();

            if(HttpContext.Session.GetString("tipoUsuario")== "1")
            ViewData["Comentarios"] = comentarioRepositorio.Listar();
            else
                ViewData["Comentarios"] = comentarioRepositorio.ListarEMostrar();

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