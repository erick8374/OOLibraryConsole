using System;

namespace OOLibrary.Domain.Acervo
{
    public class Emprestimo
    {
        public Livro Livro { get; private set; }
        public DateTime DataEmprestimo { get; private set; }
        public DateTime DataDevolucao { get; set; } // Tornar o setter acessível
        public DateTime? DataRetorno { get; set; }
        public decimal Multa
        {
            get
            {
                if (DataRetorno.HasValue && DataRetorno.Value > DataDevolucao)
                {
                    return (decimal)(DataRetorno.Value - DataDevolucao).TotalDays * 2;
                }
                return 0;
            }
        }

        public Emprestimo(Livro livro, DateTime dataEmprestimo, DateTime dataDevolucao)
        {
            Livro = livro;
            DataEmprestimo = dataEmprestimo;
            DataDevolucao = dataDevolucao;
        }
    }
}

