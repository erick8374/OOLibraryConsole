using System;
using System.Collections.Generic;
using System.Linq;

namespace OOLibrary.Domain.Acervo
{
    public class Livro
    {
        private static int proximoId = 1;
        private int Id { get; set; }
        public string Titulo { get; set; }
        public List<Autor> Autores { get; set; } = new List<Autor>();
        public string ISBN { get; set; }
        public DateTime DataPublicacao { get; set; }
        public List<string> Genero { get; set; } = new List<string>();
        public int NumeroPaginas { get; set; }

        public Livro(string titulo, Autor autor, string isbn, DateTime dataPublicacao, string genero, int numeroPaginas)
        {
            Id = proximoId++;
            Titulo = titulo;
            Autores.Add(autor);
            ISBN = isbn;
            DataPublicacao = dataPublicacao;
            Genero.Add(genero);
            NumeroPaginas = numeroPaginas;
        }

        public Livro()
        {
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine($"ID: {Id}, Título: {Titulo}, ISBN: {ISBN}, Data de Publicação: {DataPublicacao}, Número de Páginas: {NumeroPaginas}");
            Console.WriteLine("Autores: " + string.Join(", ", Autores.Select(a => a.Nome)));
            Console.WriteLine("Gêneros: " + string.Join(", ", Genero));
        }
    }

}
