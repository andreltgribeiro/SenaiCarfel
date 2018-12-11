using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.AspNetCore.Http;
using Senai.Projeto.Carfel.CheckPoint.MVC.Controllers;
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

        /// <summary>
        /// Cria um novo comentário no arquivo serializado
        /// </summary>
        /// <param name="comentario"></param>
        /// <returns>comentário que foi criado</returns>
        public ComentarioModel Criar(ComentarioModel comentario){

            /// <summary>
            /// Conta comentários já escritos e adciona um número ao ID
            /// </summary>
            comentario.Id = ComentariosSalvos.Count + 1;

            /// <summary>
            /// Adciona comentario
            /// </summary>
            ComentariosSalvos.Add(comentario);

            EscreverNoArquivo();
            EnviarEmail();

            return comentario;
        }

        public void EnviarEmail(){

        /// Instancia o System.Net.Mail.SmtpClient
        System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();

        ///Seleciona um host 
        client.Host = "smtp.gmail.com";

        ///Habilita SSL
        client.EnableSsl = true;
        ///Instancia credentials e seleciona o email credencial
        client.Credentials = new System.Net.NetworkCredential("carfelemail@gmail.com", "adminCarfel123");
        ///Instancia MailMessege
        MailMessage mail = new MailMessage();
        
        ///Instancia o enviador do email
        mail.Sender = new System.Net.Mail.MailAddress("andreltgribeiro@gmail.com", "andreltgribeiro@gmail.com");

        ///Instancia de quem o email vai ser enviado
        mail.From = new MailAddress("andreltgribeiro@gmail.com", "andreltgribeiro@gmail.com");

        ///Instancia pra quem o email será enviado
        mail.To.Add(new MailAddress("carfelemail@gmail.com", "carfelemail@gmail.com"));

        ///Assunto do email
        mail.Subject = "Comentários Carfel";
  
        ///Corpo do email
        mail.Body = "Você tem um comentário para ser aprovado ";

        ///Habilita o bodyHtml
        mail.IsBodyHtml = true;

        ///Indica a prioridade do email    
        mail.Priority = MailPriority.High;

        /// <summary>
        /// Laço para enviar o emaik
        /// </summary>
        /// <value></value>
        try
        {
            ///Envia o email
            client.Send(mail);
        }
        catch (System.Exception)
        {
           //trata erro
        }
        finally
        {
            mail = null;
        }
        }
        
        public void EscreverNoArquivo(){
            
            //MemoryStream: vai guardar os bytes da serialização
            MemoryStream memoria = new MemoryStream();
            //BinaryFormatter: Objeto que fará a serialização
            BinaryFormatter serializadora = new BinaryFormatter();

            ///Serializa os dados do comentarios salvos e armazena na memória
            serializadora.Serialize(memoria, ComentariosSalvos);

            //Pegando os bytes salvos na memória
            byte[] bytes = memoria.ToArray();

            ///Escreve os bytes da memória
            File.WriteAllBytes("comentarios.dat", bytes);
        }


        /// <summary>
        /// Lista os Comentários e os ordena por data da criação
        /// </summary>
        /// <returns>Comentários ordenados</returns>
        public List<ComentarioModel> Listar(){
            return ComentariosSalvos.OrderBy(x => x.DataCriacao).Reverse().ToList();
        }

        /// <summary>
        /// Lê o arquivo serializado
        /// </summary>
        /// <returns> lista com a memoria já sem serialização</returns>
        public List<ComentarioModel> LerArquivoSerializado(){

            ///Lê arquivo serializado e armazena em um array
            byte[] bytesSerializados = File.ReadAllBytes("comentarios.dat");

            ///Armazena os bytes serializados na memória
            MemoryStream memoria = new MemoryStream(bytesSerializados);

            ///Instancia  BynaryFormatter
            BinaryFormatter serializador = new BinaryFormatter();

            return (List<ComentarioModel>) serializador.Deserialize(memoria);
        }

        /// <summary>
        /// Busca Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Comentário que contém o id buscado</returns>
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


        /// <summary>
        /// Exclui comentário
        /// </summary>
        /// <param name="id"></param>
        public void Excluir(int id){
            
            /// Encontra o comentário que foi achado pelo método BuscarPorId
            ComentarioModel comentarioBuscado = BuscarPorId(id);

                ///Verifica se a resposta do método BuscarPorId não é null
                if(comentarioBuscado != null){

                    ///Remove comentário
                    ComentariosSalvos.Remove(comentarioBuscado);

                    ///Escreve no arquivo
                    EscreverNoArquivo();
                }
        }


        /// <summary>
        /// Aprova comentário
        /// </summary>
        /// <param name="id"></param>
        public void Aprovar(int id){

             /// Encontra o comentário que foi achado pelo método BuscarPorId
            ComentarioModel comentarioBuscado = BuscarPorId(id);

                ///Verifica se a resposta do método BuscarPorId não é null
                if(comentarioBuscado != null){

                    ///Define que o comentário que foi aprovado possui a propriedade "Aprovado" como true
                    comentarioBuscado.Aprovado = true;

                    ///Escreve no arquivo
                    EscreverNoArquivo();
                }
        }
    }
}