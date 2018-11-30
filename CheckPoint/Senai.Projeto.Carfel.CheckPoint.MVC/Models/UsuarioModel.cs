namespace Senai.Projeto.Carfel.CheckPoint.MVC.Models
{
    public class UsuarioModel
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Id { get; set; }
        public bool Administrador { get; set;}
        public string ConfirmaSenha { get; set; }


        public UsuarioModel()
        {

        }
        public UsuarioModel(int id, string nome, string email, string senha, bool administrador)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Administrador = administrador;
            
        }
        public UsuarioModel(string nome, string email, string senha, bool administrador)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            this.Administrador = administrador;
            
        }
        
        public UsuarioModel(string email, string senha){
            this.Email = email;
            this.Senha = senha;
        }

        public UsuarioModel(string nome, string email, string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            
        }
        public UsuarioModel(int id, string nome, string email, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
            
        }
    }
}