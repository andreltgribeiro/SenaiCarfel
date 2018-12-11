using System.Collections.Generic;
using Senai.Projeto.Carfel.CheckPoint.MVC.Models;

namespace Senai.Projeto.Carfel.CheckPoint.MVC.Interfaces
{
    public interface IComentario
    {

        /// <summary>
        /// Cria comentários
        /// </summary>
        /// <param name="comentarioModel"></param>
        /// <returns>Comentário criado</returns>
        ComentarioModel Criar (ComentarioModel comentarioModel);


        /// <summary>
        /// Exclui Comentário
        /// </summary>
        /// <param name="id"></param>
         void Excluir(int id);


        /// <summary>
        /// Escreve no arquivo serializado
        /// </summary>
         void EscreverNoArquivo();



        /// <summary>
        /// Lista Arquivo serializado
        /// </summary>
        /// <returns>Lista com comentários</returns>
        List<ComentarioModel> Listar();

        
        
        /// <summary>
        /// Busca por id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Comentário que foi buscado</returns>
        ComentarioModel BuscarPorId(int id);

        /// <summary>
        /// Muda o status da propriedades Aprovado para
        /// </summary>
        /// <param name="id"></param>
        void Aprovar(int id);

        
    }
}