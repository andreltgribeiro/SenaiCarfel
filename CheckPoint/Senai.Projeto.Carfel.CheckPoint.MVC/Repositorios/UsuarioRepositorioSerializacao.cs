using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Senai.Projeto.Carfel.CheckPoint.MVC.Interfaces;
using Senai.Projeto.Carfel.CheckPoint.MVC.Models;

namespace Senai.Projeto.Carfel.CheckPoint.MVC.Repositorios
{
    public class UsuarioRepositorioSerializacao : IUsuario
    {
        private List<UsuarioModel> UsuariosSalvos {get; set; }

        public UsuarioRepositorioSerializacao(){
            if(File.Exists("usuarios.dat")){
                UsuariosSalvos = LerArquivoSerializado();
            }else{
                UsuariosSalvos = new List<UsuarioModel>();
            }

        }

        public UsuarioModel EmailSenha (string email, string senha){
            List<UsuarioModel> usuariosCadastrados = LerArquivoSerializado();

            foreach (UsuarioModel usuario in usuariosCadastrados)
            {
                if (usuario.Email == email && usuario.Senha == senha)
                {
                    return usuario;
                }
            }

            return null;
        }
        public UsuarioModel BuscarPorId(int id){
            foreach (UsuarioModel usuario in UsuariosSalvos)
            {
                if(id == usuario.Id){
                    return usuario;
                }
            }
            return null;
        }

        public UsuarioModel Cadastrar(UsuarioModel usuario){
            usuario.Id = UsuariosSalvos.Count + 1;
            UsuariosSalvos.Add(usuario);
            
            EscreverNoArquivo();

            return usuario;
        }

        private void EscreverNoArquivo(){
            //MemoryStream: vai guardar os bytes da serialização
            MemoryStream memoria = new MemoryStream();
            //BinaryFormatter: Objeto que fará a serialização
            BinaryFormatter serializadora = new BinaryFormatter();

            serializadora.Serialize(memoria, UsuariosSalvos);

            //Pegando os bytes salvos na memória
            byte[] bytes = memoria.ToArray();

            File.WriteAllBytes("usuarios.dat", bytes);
        }

        public List<UsuarioModel> Listar(){
            return UsuariosSalvos;
        }

        public List<UsuarioModel> LerArquivoSerializado(){
            byte[] bytesSerializados = File.ReadAllBytes("usuarios.dat");

            MemoryStream memoria = new MemoryStream(bytesSerializados);

            BinaryFormatter serializador = new BinaryFormatter();

            return (List<UsuarioModel>) serializador.Deserialize(memoria);
        }
    }
}