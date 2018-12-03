using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using Senai.Projeto.Carfel.CheckPoint.MVC.Interfaces;
using Senai.Projeto.Carfel.CheckPoint.MVC.Models;

namespace Senai.Projeto.Carfel.CheckPoint.MVC.Repositorios
{
    public class ComentarioRepositorioSerializacao : IComentario
    {
        private List<ComentarioModel> ComentariosSalvos {get; set;}

        public ComentarioRepositorioSerializacao(){
            if(File.Exists("comentarios.dat")){
                ComentariosSalvos = LerArquivoSerializado();

            }else{
                ComentariosSalvos = new List<ComentarioModel>();
            }
        }

        public ComentarioModel Criar(ComentarioModel comentario){
            comentario.Id = ComentariosSalvos.Count + 1;

            ComentariosSalvos.Add(comentario);

            EscreverNoArquivo();

            return comentario;
        }

        public void EscreverNoArquivo(){
            //MemoryStream: vai guardar os bytes da serialização
            MemoryStream memoria = new MemoryStream();
            //BinaryFormatter: Objeto que fará a serialização
            BinaryFormatter serializadora = new BinaryFormatter();

            serializadora.Serialize(memoria, ComentariosSalvos);

            //Pegando os bytes salvos na memória
            byte[] bytes = memoria.ToArray();

            File.WriteAllBytes("comentarios.dat", bytes);
        }
        public List<ComentarioModel> Listar(){
            return ComentariosSalvos.OrderBy(x => x.DataCriacao).Reverse().ToList();
        }
        public List<ComentarioModel> LerArquivoSerializado(){
            byte[] bytesSerializados = File.ReadAllBytes("comentarios.dat");

            MemoryStream memoria = new MemoryStream(bytesSerializados);

            BinaryFormatter serializador = new BinaryFormatter();

            return (List<ComentarioModel>) serializador.Deserialize(memoria);
        }
        public ComentarioModel BuscarPorId(int id)
        {
            //Percorre todos os usuários buscando pelo id...
            foreach (ComentarioModel comentario in ComentariosSalvos)
            {
                if (id == comentario.Id)
                {
                    return comentario;
                }
            }
            
            //Caso não encontre o usuário pelo id
            return null;
        }

        public void Excluir(int id){
            ComentarioModel comentarioBuscado = BuscarPorId(id);
                if(comentarioBuscado != null){
                    ComentariosSalvos.Remove(comentarioBuscado);

                    EscreverNoArquivo();
                }
        }
        public void Aprovar(int id){
            ComentarioModel comentarioBuscado = BuscarPorId(id);
                if(comentarioBuscado != null){
                    comentarioBuscado.Aprovado = true;
                    EscreverNoArquivo();
                }
        }
    }
}