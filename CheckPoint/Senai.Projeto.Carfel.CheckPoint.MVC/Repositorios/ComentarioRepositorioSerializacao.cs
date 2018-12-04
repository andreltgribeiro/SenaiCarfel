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

        public ComentarioModel Criar(ComentarioModel comentario){
            comentario.Id = ComentariosSalvos.Count + 1;

            ComentariosSalvos.Add(comentario);

            EscreverNoArquivo();
            EnviarEmail();

            return comentario;
        }

        public void EnviarEmail(){
            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
        client.Host = "smtp.gmail.com";
        client.EnableSsl = true;
        client.Credentials = new System.Net.NetworkCredential("carfelemail@gmail.com", "adminCarfel123");
        MailMessage mail = new MailMessage();
        mail.Sender = new System.Net.Mail.MailAddress("andreltgribeiro@gmail.com", "andreltgribeiro@gmail.com");
        mail.From = new MailAddress("andreltgribeiro@gmail.com", "andreltgribeiro@gmail.com");
        mail.To.Add(new MailAddress("carfelemail@gmail.com", "carfelemail@gmail.com"));
        mail.Subject = "Comentários Carfel";
        mail.Body = "Você tem um email para ser aprovado "; 
        mail.IsBodyHtml = true;
        mail.Priority = MailPriority.High;
        try
        {
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