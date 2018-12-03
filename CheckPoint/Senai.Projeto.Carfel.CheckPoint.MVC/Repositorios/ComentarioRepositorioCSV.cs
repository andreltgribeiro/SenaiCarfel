using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Senai.Projeto.Carfel.CheckPoint.MVC.Models;

namespace Senai.Projeto.Carfel.CheckPoint.MVC.Repositorios {
    public class ComentarioRepositorioCSV {
        public ComentarioModel Criar (ComentarioModel comentarioModel) {

            if (File.Exists ("comentarios.csv")) {
                comentarioModel.Id = System.IO.File.ReadAllLines ("comentarios.csv").Length + 1;

            } else {
                comentarioModel.Id = 1;
            }
            UsuarioModel usuario = new UsuarioModel ();

            using (StreamWriter escrever = new StreamWriter ("comentarios.csv", true)) {
                if (comentarioModel.Aprovado == false) {
                    escrever.WriteLine ($"{comentarioModel.Id};{comentarioModel.nomeUsuario};{comentarioModel.Texto};{comentarioModel.DataCriacao};0");
                }

            }
            return comentarioModel;
        }

        public List<ComentarioModel> Listar () => LerCSV ();
        private List<ComentarioModel> LerCSV () {
            List<ComentarioModel> lsComentarios = new List<ComentarioModel> ();

            if (File.Exists ("comentarios.csv")) {
                string[] lines = File.ReadAllLines ("comentarios.csv");

                foreach (string line in lines) {
                    if (string.IsNullOrEmpty (line)) {

                        continue;
                    }

                    string[] dadosLine = line.Split (';');

                    if(dadosLine[4] == "0"){
                        ComentarioModel comentario = new ComentarioModel (
                            id: int.Parse (dadosLine[0]),
                            nomeUsuario: dadosLine[1],
                            texto: dadosLine[2],
                            dataCriacao: DateTime.Parse (dadosLine[3]),
                            aprovado: (dadosLine[4] == "1")
                        );
                        lsComentarios.Add(comentario);
                    }
                }
            } 
            return lsComentarios.OrderBy(x => x.DataCriacao).Reverse().ToList();
        }
        public static void Excluir(int id)
        {
            //Abre o stream de leitura do arquivo
            string[] linhas = File.ReadAllLines("comentarios.csv");

            //Lê cada registro no CSV
            for (int i = 0; i < linhas.Length; i++)
            {
                //Separa os dados da linha
                string[] dadosDaLinha = linhas[i].Split(';');

                if (id.ToString() == dadosDaLinha[0]) {
                    linhas[i] = "";
                    break;
                }
            }  

            File.WriteAllLines("comentarios.csv", linhas);
        }
        public static void Aprovar(int id)
        {
            //Abre o stream de leitura do arquivo
            string[] linhas = File.ReadAllLines("comentarios.csv");

            //Lê cada registro no CSV
            for (int i = 0; i < linhas.Length; i++)
            {
                //Separa os dados da linha
                string[] dadosDaLinha = linhas[i].Split(';');

                if (id.ToString() == dadosDaLinha[0]) {
                    
                    linhas[i] = $"{dadosDaLinha[0]};{dadosDaLinha[1]};{dadosDaLinha[2]};{dadosDaLinha[3]};1";
                    continue;
                }
            }  

            File.WriteAllLines("comentarios.csv", linhas);
        }
    }
}