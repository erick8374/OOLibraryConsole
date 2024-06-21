using OOLibraryConsole.Domain.Acervo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOLibraryConsole.Domain.Acervo
{
    public class Exemplar : Livro
    {
        private static int proximoId = 1;
        private int Id { get; set; }
        public string EstadoConservacao { get; set; }
        public DateTime DataAquisicao { get; set; }
        public bool Disponivel { get; set; }

        public Livro Livro { get; set; }

        public Exemplar(int id, Livro livro)
        {
            Id = proximoId++;
            EstadoConservacao = "Bom";
            DataAquisicao = DateTime.Now;
            Disponivel = true;
            Livro = livro;
        }

        public Exemplar(string titulo, Autor autor, string isbn, DateTime dataPublicacao, string genero, int numeroPaginas)
        : base(titulo, autor, isbn, dataPublicacao, genero, numeroPaginas)
        {
            EstadoConservacao = "Bom";
            DataAquisicao = DateTime.Now;
            Disponivel = true;
        }
    }

}
