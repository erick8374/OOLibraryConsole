using OOLibrary.Domain.Acervo;
using OOLibrary.Domain.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOLibrary.Domain
{
    public class Biblioteca
    {
        public string Nome { get; set; }
        public List<Colecao> Colecoes { get; set; }
        public List<Usuario> Usuarios { get; set; }

        public Biblioteca(string nome)
        {
            Nome = nome;
            Colecoes = new List<Colecao>();
            Usuarios = new List<Usuario>();
        }

        public void AdicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public void AdicionarColecao(Colecao colecao)
        {
            Colecoes.Add(colecao);
        }

        public Livro BuscarLivro(string titulo)
        {
            foreach (var colecao in Colecoes)
            {
                foreach (var livro in colecao.Livros)
                {
                    if (livro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                    {
                        return livro;
                    }
                }
            }
            return null;
        }

        public Usuario AutenticarUsuario(string email, string senha)
        {
            Usuario usuario = Usuarios.FirstOrDefault(u => u.Email == email);
            if (usuario != null && usuario.VerificarSenha(senha))
            {
                return usuario;
            }
            return null;
        }
    }
}
