using System;

namespace OOLibrary.Domain.Acervo
{
    public class Autor
    {
        private static int proximoId = 1;
        private int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; }
        public DateTime DataMorte { get; }

        public Autor()
        {
        }
        public Autor(string nome)
        {
            Id = proximoId++;
            Nome = nome;
        }
        public Autor(string nome, DateTime dataNascimento, DateTime dataMorte)
        {
            Id = proximoId++;
            Nome = nome;
            DataNascimento = dataNascimento;
            DataMorte = dataMorte;
        }

        public override string ToString()
        {
            return $"{Nome} (Nascimento: {DataNascimento.ToShortDateString()}, Morte: {DataMorte.ToShortDateString()})";
        }
    }
}
