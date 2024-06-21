using System;

namespace OOLibraryConsole.Domain.Cadastro
{
    public class Funcionario : Usuario
    {
        public string Cargo { get; set; }
        public float Salario { get; set; }

        public Funcionario(string nome, string sobrenome, string email, string senha, string cargo, float salario)
            : base(nome, sobrenome, email, senha)
        {
            Cargo = cargo;
            Salario = salario;
        }

        public override void MostrarInformacoes()
        {
            Console.WriteLine($"Funcionário: {Nome} {Sobrenome}, Cargo: {Cargo}, Salário: {Salario}");
        }
    }
}
