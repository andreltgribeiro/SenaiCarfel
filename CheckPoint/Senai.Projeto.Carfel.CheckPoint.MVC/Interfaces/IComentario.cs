using System.Collections.Generic;
using Senai.Projeto.Carfel.CheckPoint.MVC.Models;

namespace Senai.Projeto.Carfel.CheckPoint.MVC.Interfaces
{
    public interface IComentario
    {
        ComentarioModel Criar (ComentarioModel comentarioModel);

         void Excluir(int id);

         void EscreverNoArquivo();

        List<ComentarioModel> Listar();

        ComentarioModel BuscarPorId(int id);

        void Aprovar(int id);
    }
}