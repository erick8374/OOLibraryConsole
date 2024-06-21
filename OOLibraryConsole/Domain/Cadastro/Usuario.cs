using System;

namespace OOLibraryConsole.Domain.Cadastro
{
    public abstract class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }

        protected Usuario(string nome, string sobrenome, string email, string senha)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Email = email;
            Senha = senha;
        }

        public bool VerificarSenha(string senha)
        {
            return Senha == senha;
        }

        public abstract void MostrarInformacoes();
    }
}
