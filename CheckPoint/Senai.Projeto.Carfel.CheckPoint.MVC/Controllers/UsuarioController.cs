using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Projeto.Carfel.CheckPoint.MVC.Interfaces;
using Senai.Projeto.Carfel.CheckPoint.MVC.Models;
using Senai.Projeto.Carfel.CheckPoint.MVC.Repositorios;

namespace Senai.Projeto.Carfel.CheckPoint.MVC.Controllers
{
    public class UsuarioController : Controller
    {

        public IUsuario UsuarioRepositorio {get; set;}

        public UsuarioController()
        {
            UsuarioRepositorio = new UsuarioRepositorioSerializacao();
        }
        
        [HttpGet]
        public IActionResult Cadastro (){
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(IFormCollection form){
            UsuarioModel usuarioModel = new UsuarioModel(nome:form["nome"], email:form["email"], senha:form["senha"]);

            usuarioModel.Nome = form["nome"];
            usuarioModel.Email = form["email"];
            usuarioModel.Senha = form["senha"];
                
            UsuarioRepositorio.Cadastrar(usuarioModel);

            ViewBag.Mensagem = "Usuário Cadastrado";

            return View();
        }
        [HttpGet]
        public IActionResult CadastroAdmin (){
            return View();
        }

        [HttpPost]
        public IActionResult CadastroAdmin(IFormCollection form){
            UsuarioModel usuarioModel = new UsuarioModel(nome:form["nome"], email:form["email"], senha:form["senha"], administrador: true);

            usuarioModel.Nome = form["nome"];
            usuarioModel.Email = form["email"];
            usuarioModel.Senha = form["senha"];
            usuarioModel.ConfirmaSenha = form["confirmaSenha"];

            ViewBag.Mensagem = "Usuário Cadastrado";

            return View();
        }

        [HttpGet]
        public IActionResult Login(){
            return View();
        }
        
        [HttpPost]
        public IActionResult Login(IFormCollection form){
            UsuarioModel usuario = new UsuarioModel( email: form["email"], senha: form["senha"]);

            
            UsuarioModel usuarioModel = UsuarioRepositorio.EmailSenha(usuario.Email, usuario.Senha);

            if(usuarioModel != null){
                if(usuarioModel.Email.Contains("admin@carfel.com")){
                HttpContext.Session.SetString("idUsuario", usuarioModel.Id.ToString());
                HttpContext.Session.SetString("emailUsuario", usuarioModel.Email.ToString());
                HttpContext.Session.SetString("nomeUsuario", usuarioModel.Nome.ToString());
                HttpContext.Session.SetString("tipoUsuario", usuarioModel.Administrador.ToString());
        
                usuarioModel.Administrador = true;
                return RedirectToAction ("IndexADM", "HomeADM");
            }
                HttpContext.Session.SetString("idUsuario", usuarioModel.Id.ToString());
                HttpContext.Session.SetString("emailUsuario", usuarioModel.Email.ToString());
                HttpContext.Session.SetString("nomeUsuario", usuarioModel.Nome.ToString());

                ViewBag.LoginSucesso = "Login Efetuado";
                
                return RedirectToAction ("Index", "Home");
            }else{
                ViewBag.LoginFalha = "Acesso inválido";
            }
            
            return View();
        }
        [HttpGet]
        public IActionResult LoginAdmin(){
            return View();
        }
        
        [HttpPost]
        public IActionResult LoginAdmin(IFormCollection form){
            UsuarioModel usuario = new UsuarioModel( email: form["email"], senha: form["senha"]);

            
            UsuarioModel usuarioModel = UsuarioRepositorio.EmailSenha(usuario.Email, usuario.Senha);

            

            if(usuarioModel != null){
                if(usuarioModel.Email.Contains("admin@carfel.com")){
                HttpContext.Session.SetString("idUsuario", usuarioModel.Id.ToString());
                HttpContext.Session.SetString("emailUsuario", usuarioModel.Email.ToString());
                HttpContext.Session.SetString("nomeUsuario", usuarioModel.Nome.ToString());
                
                usuarioModel.Administrador = true;
                return RedirectToAction ("IndexADM", "HomeADM");
            }
                HttpContext.Session.SetString("idUsuario", usuarioModel.Id.ToString());
                HttpContext.Session.SetString("emailUsuario", usuarioModel.Email.ToString());
                HttpContext.Session.SetString("nomeUsuario", usuarioModel.Nome.ToString());

                ViewBag.LoginSucesso = "Login Efetuado";
                
                return RedirectToAction ("Index", "Home");
            }else{
                ViewBag.LoginFalha = "Acesso inválido";
            }
            
            return View();
        }
        [HttpGet]
        public IActionResult Deslogar(){
            HttpContext.Session.Clear();
            return View();
        }
    }
}