using OOLibrary.Domain.Acervo;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOLibrary.Domain.Cadastro
{
    public class Associado : Usuario
    {
        public DateTime DataAdesao { get; set; }
        public List<Emprestimo> Emprestimos { get; set; }

        public Associado(string nome, string sobrenome, string email, string senha, DateTime dataAdesao)
            : base(nome, sobrenome, email, senha)
        {
            DataAdesao = dataAdesao;
            Emprestimos = new List<Emprestimo>();
        }

        public void AdicionarEmprestimo(Emprestimo emprestimo)
        {
            Emprestimos.Add(emprestimo);
        }

        public override void MostrarInformacoes()
        {
            throw new NotImplementedException();
        }
    }
}
