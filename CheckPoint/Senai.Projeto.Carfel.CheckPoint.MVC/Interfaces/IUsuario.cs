using System.Collections.Generic;
using Senai.Projeto.Carfel.CheckPoint.MVC.Models;

namespace Senai.Projeto.Carfel.CheckPoint.MVC.Interfaces
{
    public interface IUsuario
    {
         UsuarioModel Cadastrar(UsuarioModel usuario);
         List<UsuarioModel> Listar();
         UsuarioModel EmailSenha(string email, string senha);
         UsuarioModel BuscarPorId(int id);
    }
}