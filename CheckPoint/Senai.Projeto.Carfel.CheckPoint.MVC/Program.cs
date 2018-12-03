using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Senai.Projeto.Carfel.CheckPoint.MVC.Models;
using Senai.Projeto.Carfel.CheckPoint.MVC.Repositorios;

namespace Senai.Projeto.Carfel.CheckPoint.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UsuarioRepositorioSerializacao usuarioRepositorioSerializacao= new UsuarioRepositorioSerializacao();
            if(File.Exists("usuarios.dat")){
                List<UsuarioModel> UsuariosSalvos = usuarioRepositorioSerializacao.LerArquivoSerializado();
            }else{
                UsuarioModel usuarioModel = new UsuarioModel();

            usuarioModel.Nome = "Administrador";
            usuarioModel.Email = "admin@carfel.com";
            usuarioModel.Senha = "admin";
            usuarioModel.Administrador = true;
                
            usuarioRepositorioSerializacao.Cadastrar(usuarioModel);
            }

            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
