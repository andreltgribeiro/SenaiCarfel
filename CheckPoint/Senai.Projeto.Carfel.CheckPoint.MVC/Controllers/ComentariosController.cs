using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Projeto.Carfel.CheckPoint.MVC.Models;
using Senai.Projeto.Carfel.CheckPoint.MVC.Repositorios;
using Senai.Projeto.Carfel.CheckPoint.MVC.Interfaces;
using System.Linq;
using System.Net.Mail;

namespace Senai.Projeto.Carfel.CheckPoint.MVC.Controllers
{
    public class ComentariosController : Controller
    {
        public IComentario ComentarioRepositorio {get; set;}

        public ComentariosController(){
            /// <summary>
            ///  Transformando o comentario repositório em comentario repositorio en serialização
            /// </summary>
            ComentarioRepositorio = new ComentarioRepositorioSerializacao();
        }
        
        [HttpGet]
        public IActionResult Index(){

            /// Verificando o tipo de usuário
            if(HttpContext.Session.GetString("tipoUsuario") == "1")

                /// <summary>
                /// Listando apenas os comentáris que não foram aprovados
                /// </summary>
                /// <param name="!x.Aprovado"></param>
                /// <returns>Comentarios não aprovados</returns>
                ViewData["Comentarios"] = ComentarioRepositorio.Listar().Where(x => !x.Aprovado).ToList();
            else

                /// <summary>
                ///Listando apenas os comentáris que não foram aprovados
                /// </summary>
                /// <param name="x.Aprovado"></param>
                /// <returns>Comentários aprovados</returns>
                ViewData["Comentarios"] = ComentarioRepositorio.Listar().Where(x => x.Aprovado).ToList();

            return View();
        }
        
        [HttpPost]
        public IActionResult Index(IFormCollection form){
            ///Instancia com método construtor
            ComentarioModel comentarioModel = new ComentarioModel(texto: form["texto"],aprovado: false, nomeUsuario: HttpContext.Session.GetString("nomeUsuario"));

            ///Método que cria um novo comentário
            ComentarioRepositorio.Criar(comentarioModel);

            ///Verifica tipo de usuário
            if(HttpContext.Session.GetString("tipoUsuario") == "1")

                /// <summary>
                /// Listando apenas os comentáris que não foram aprovados
                /// </summary>
                /// <param name="!x.Aprovado"></param>
                /// <returns>Comentarios não aprovados</returns>
                ViewData["Comentarios"] = ComentarioRepositorio.Listar().Where(x => !x.Aprovado).ToList();
            else

                /// <summary>
                ///Listando apenas os comentáris que não foram aprovados
                /// </summary>
                /// <param name="x.Aprovado"></param>
                /// <returns>Comentários aprovados</returns>
                ViewData["Comentarios"] = ComentarioRepositorio.Listar().Where(x => x.Aprovado).ToList();
                
                TempData["Mensagem"] = "Comentário enviado para aprovação dos administradores";

            return View();
        }
        [HttpGet]
        public IActionResult AprovarComentarios(){

                 /// <summary>
                ///Listando apenas os comentáris que não foram aprovados
                /// </summary>
                /// <param name="!x.Aprovado"></param>
                /// <returns>Comentários não aprovados</returns>
                ViewData["Comentarios"] = ComentarioRepositorio.Listar().Where(x => !x.Aprovado).ToList();
           
            return View();
        }

        [HttpGet]
        public IActionResult ComentariosAprovados(){

                 ///Verifica tipo de usuário
                if(HttpContext.Session.GetString("tipoUsuario") == "1")

                /// <summary>
                /// Listando apenas os comentáris que não foram aprovados
                /// </summary>
                /// <param name="!x.Aprovado"></param>
                /// <returns>Comentarios aprovados</returns>
                ViewData["Comentarios"] = ComentarioRepositorio.Listar().Where(x => x.Aprovado).ToList();
            else

                /// <summary>
                /// Listando apenas os comentáris aprovados
                /// </summary>
                /// <param name="!x.Aprovado"></param>
                /// <returns>Comentarios aprovados</returns>
                ViewData["Comentarios"] = ComentarioRepositorio.Listar().Where(x => x.Aprovado).ToList();
           
            return View();
        }

        [HttpGet]
        public IActionResult EnviarEmail(){
            /// <summary>
            /// Cria página de enviar email
            /// </summary>
            /// <returns>View</returns>
            
            return View();
        }

        [HttpGet]
        public IActionResult ComentarioDeslogado (){

            ///Verifica tipo de usuário
            if(HttpContext.Session.GetString("tipoUsuario")== "1")

                /// <summary>
                /// Listando apenas os comentáris que não foram aprovados
                /// </summary>
                /// <returns>Comentarios todos os comentários</returns>
                ViewData["Comentarios"] = ComentarioRepositorio.Listar().ToList();
            else

                /// <summary>
                /// Listando apenas os comentáris aprovados
                /// </summary>
                /// <param name="x.Aprovado"></param>
                /// <returns>Comentarios aprovados</returns>
                ViewData["Comentarios"] = ComentarioRepositorio.Listar().Where(x => x.Aprovado).ToList();

            return View();
        }
        [HttpGet]
        public IActionResult Excluir(int id)
        {
            ///Exclui comentário
            ComentarioRepositorio.Excluir(id);

            TempData["Mensagem"] = "Comentario excluído";

            return RedirectToAction("AprovarComentarios");
        }
        [HttpGet]

        ///Exclui comentários já aprovados
        public IActionResult ExcluirAprovados(int id)
        {
            ///Exclui comentários já aprovados
            ComentarioRepositorio.Excluir(id);

            TempData["Mensagem"] = "Comentario excluído";

            return RedirectToAction("ComentariosAprovados");
        }

        [HttpGet]
        public IActionResult Aprovar(int id)
        {
            ///Aprova comentários
            ComentarioRepositorio.Aprovar(id);

            TempData["Mensagem"] = "Comentario Aprovado";

            return RedirectToAction("AprovarComentarios");

        }
    }
}