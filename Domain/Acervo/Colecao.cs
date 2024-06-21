using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOLibrary.Domain.Acervo
{
    public class Colecao
    {
        private static int proximoId = 1;
        private int Id { get; set; }
        public string Nome { get; set; }
        public List<Livro> Livros { get; set; } = new List<Livro>();

        public Colecao() { }

        public Colecao( string nome)
        {
            Id= proximoId++;
            Nome = nome;
        }

        // Método para mostrar informações da coleção
        public void MostrarInformacoes()
        {
            Console.WriteLine($"Coleção: {Nome}, ID: {Id}");
            Console.WriteLine("Livros na Coleção:");
            foreach (var livro in Livros)
            {
                Console.WriteLine($" - {livro.Titulo}");
            }
        }

        // Método para adicionar um livro à coleção
        public void AdicionarLivro(Livro livro)
        {
            if (livro != null && !Livros.Contains(livro))
            {
                Livros.Add(livro);
                Console.WriteLine($"Livro '{livro.Titulo}' adicionado à coleção '{Nome}'.");
            }
        }

        // Método para remover um livro da coleção
        public void RemoverLivro(Livro livro)
        {
            if (livro != null && Livros.Contains(livro))
            {
                Livros.Remove(livro);
                Console.WriteLine($"Livro '{livro.Titulo}' removido da coleção '{Nome}'.");
            }
        }
    }
}
