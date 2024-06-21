using OOLibraryConsole.Domain;
using OOLibraryConsole.Domain.Acervo;
using OOLibraryConsole.Domain.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOLibrary
{
    static class Program
    {
        public static Usuario FuncionarioPrincipal { get; private set; }
        public static Biblioteca Biblioteca { get; private set; }

        [STAThread]
        static void Main()
        {
            // Criar 8 usuários associados
            List<Associado> associados = new List<Associado>
            {
                new Associado("João", "Silva", "joao.silva@gmail.com", "senha123", DateTime.Now),
                new Associado("Maria", "Souza", "maria.souza@gmail.com", "senha456", DateTime.Now),
                new Associado("Pedro", "Oliveira", "pedro.oliveira@gmail.com", "senha789", DateTime.Now),
                new Associado("Ana", "Costa", "ana.costa@gmail.com", "senha101", DateTime.Now),
                new Associado("Carlos", "Lima", "carlos.lima@gmail.com", "senha102", DateTime.Now),
                new Associado("Mariana", "Ribeiro", "mariana.ribeiro@gmail.com", "senha103", DateTime.Now),
                new Associado("Paulo", "Fernandes", "paulo.fernandes@gmail.com", "senha104", DateTime.Now),
                new Associado("Juliana", "Pereira", "juliana.pereira@gmail.com", "senha105", DateTime.Now)
            };

            // Criar 2 funcionários
            List<Funcionario> funcionarios = new List<Funcionario>
            {
                new Funcionario("Ricardo", "Mendes", "ricardo.mendes@gmail.com", "senha106", "Bibliotecário", 2500.00f),
                new Funcionario("Fernanda", "Almeida", "fernanda.almeida@gmail.com", "senha107", "Assistente", 2000.00f)
            };

            // Criar 5 coleções
            List<Colecao> colecoes = new List<Colecao>
            {
                new Colecao("Literatura Brasileira"),
                new Colecao("Ciência e Tecnologia"),
                new Colecao("História"),
                new Colecao("Ficção Científica"),
                new Colecao("Biografias")
            };

            // Criar autores para os livros
            Autor autor1 = new Autor("Machado de Assis");
            Autor autor2 = new Autor("Isaac Asimov");
            Autor autor3 = new Autor("Yuval Noah Harari");
            Autor autor4 = new Autor("George Orwell");
            Autor autor5 = new Autor("Jane Austen");

            // Criar 5 livros para cada coleção
            List<Livro> livros = new List<Livro>
            {
                // Literatura Brasileira
                new Livro("Dom Casmurro", autor1, "978-1234567890", new DateTime(1899, 1, 1), "Romance", 256),
                new Livro("Memórias Póstumas de Brás Cubas", autor1, "978-1234567891", new DateTime(1881, 1, 1), "Romance", 208),
                new Livro("O Alienista", autor1, "978-1234567892", new DateTime(1882, 1, 1), "Conto", 96),
                new Livro("Quincas Borba", autor1, "978-1234567893", new DateTime(1891, 1, 1), "Romance", 312),
                new Livro("Esaú e Jacó", autor1, "978-1234567894", new DateTime(1904, 1, 1), "Romance", 250),

                // Ciência e Tecnologia
                new Livro("Eu, Robô", autor2, "978-1234567895", new DateTime(1950, 1, 1), "Ficção Científica", 224),
                new Livro("Fundação", autor2, "978-1234567896", new DateTime(1951, 1, 1), "Ficção Científica", 244),
                new Livro("O Fim da Eternidade", autor2, "978-1234567897", new DateTime(1955, 1, 1), "Ficção Científica", 192),
                new Livro("Nêmesis", autor2, "978-1234567898", new DateTime(1989, 1, 1), "Ficção Científica", 386),
                new Livro("Os Próprios Deuses", autor2, "978-1234567899", new DateTime(1972, 1, 1), "Ficção Científica", 288),

                // História
                new Livro("Sapiens: Uma Breve História da Humanidade", autor3, "978-9876543210", new DateTime(2011, 1, 1), "História", 512),
                new Livro("Homo Deus: Uma Breve História do Amanhã", autor3, "978-9876543211", new DateTime(2015, 1, 1), "História", 448),
                new Livro("21 Lições para o Século 21", autor3, "978-9876543212", new DateTime(2018, 1, 1), "História", 432),
                new Livro("O Declínio do Ocidente", autor3, "978-9876543213", new DateTime(1918, 1, 1), "História", 784),
                new Livro("Uma Breve História do Tempo", autor3, "978-9876543214", new DateTime(1988, 1, 1), "História", 256),

                // Ficção Científica
                new Livro("1984", autor4, "978-8765432109", new DateTime(1949, 1, 1), "Distopia", 328),
                new Livro("A Revolução dos Bichos", autor4, "978-8765432110", new DateTime(1945, 1, 1), "Distopia", 112),
                new Livro("Admirável Mundo Novo", autor4, "978-8765432111", new DateTime(1932, 1, 1), "Distopia", 264),
                new Livro("Fahrenheit 451", autor4, "978-8765432112", new DateTime(1953, 1, 1), "Distopia", 158),
                new Livro("Laranja Mecânica", autor4, "978-8765432113", new DateTime(1962, 1, 1), "Distopia", 192),

                // Biografias
                new Livro("Orgulho e Preconceito", autor5, "978-1234509876", new DateTime(1813, 1, 1), "Romance", 432),
                new Livro("Emma", autor5, "978-1234509877", new DateTime(1815, 1, 1), "Romance", 474),
                new Livro("Razão e Sensibilidade", autor5, "978-1234509878", new DateTime(1811, 1, 1), "Romance", 408),
                new Livro("Persuasão", autor5, "978-1234509879", new DateTime(1817, 1, 1), "Romance", 304),
                new Livro("Mansfield Park", autor5, "978-1234509880", new DateTime(1814, 1, 1), "Romance", 528)
            };

            // Adicionar livros às coleções
            colecoes[0].AdicionarLivro(livros[0]);
            colecoes[0].AdicionarLivro(livros[1]);
            colecoes[0].AdicionarLivro(livros[2]);
            colecoes[0].AdicionarLivro(livros[3]);
            colecoes[0].AdicionarLivro(livros[4]);

            colecoes[1].AdicionarLivro(livros[5]);
            colecoes[1].AdicionarLivro(livros[6]);
            colecoes[1].AdicionarLivro(livros[7]);
            colecoes[1].AdicionarLivro(livros[8]);
            colecoes[1].AdicionarLivro(livros[9]);

            colecoes[2].AdicionarLivro(livros[10]);
            colecoes[2].AdicionarLivro(livros[11]);
            colecoes[2].AdicionarLivro(livros[12]);
            colecoes[2].AdicionarLivro(livros[13]);
            colecoes[2].AdicionarLivro(livros[14]);

            colecoes[3].AdicionarLivro(livros[15]);
            colecoes[3].AdicionarLivro(livros[16]);
            colecoes[3].AdicionarLivro(livros[17]);
            colecoes[3].AdicionarLivro(livros[18]);
            colecoes[3].AdicionarLivro(livros[19]);

            colecoes[4].AdicionarLivro(livros[20]);
            colecoes[4].AdicionarLivro(livros[21]);
            colecoes[4].AdicionarLivro(livros[22]);
            colecoes[4].AdicionarLivro(livros[23]);
            colecoes[4].AdicionarLivro(livros[24]);

            foreach (Associado associado in associados)
            {
                Random random = new Random();
                int numEmprestimos = random.Next(1, 4);
                for (int i = 0; i < numEmprestimos; i++)
                {
                    Livro livroSelecionado = livros[random.Next(livros.Count)];

                    Emprestimo emprestimo = new Emprestimo(livroSelecionado, DateTime.Now, DateTime.Now.AddDays(14)); // Prazo de 14 dias

                    associado.AdicionarEmprestimo(emprestimo);

                    livros.Remove(livroSelecionado);
                }
            }



            Biblioteca = new Biblioteca("Biblioteca",colecoes, funcionarios, associados);

            FuncionarioPrincipal = Login(Biblioteca); //UsuarioLogado

                if (FuncionarioPrincipal!=null)
                {
                    if (FuncionarioPrincipal is Funcionario)
                    {
                        MenuFuncionario(FuncionarioPrincipal);
                    }
                    else
                    {
                        MenuAssociado(FuncionarioPrincipal);
                    }
                }
                else
                {
                    Console.WriteLine("Login falhou. Tente novamente.");
                }
          

        }
        static Usuario Login(Biblioteca biblioteca)
        {
            Console.WriteLine("Bem-vindo à Biblioteca!");
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Senha: ");
            string senha = Console.ReadLine();
            Usuario usuario = biblioteca.AutenticarUsuario(email, senha);
            if (usuario != null)
            {
                if (usuario is Funcionario)
                {
                    FuncionarioPrincipal = (Funcionario)usuario;
                    return usuario;
                }
                else
                {
                    Console.WriteLine("Login bem-sucedido como Associado.");
                    return usuario;
                }
            }

            return null;
        }


        private static void MenuFuncionario(Usuario funcionario)
        {
            bool executando = true;
            while (executando)
            {
                Console.Clear();
                Console.WriteLine("Bem-vindo à Biblioteca!");
                Console.WriteLine("1. Mostrar Catálogo");
                Console.WriteLine("2. Abrir Empréstimos");
                Console.WriteLine("3. Abrir Dados dos Autores");
                Console.WriteLine("4. Excluir Livro de Coleção");
                Console.WriteLine("5. Excluir Coleção da Biblioteca");
                Console.WriteLine("6. Mostrar Informações do Funcionário");
                Console.WriteLine("7. Sair");
                Console.Write("Escolha uma opção: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        MostrarCatalogo();
                        break;
                    case "2":
                        AbrirEmprestimos();
                        break;
                    case "3":
                        AbrirDadosAutores();
                        break;
                    case "4":
                        ExcluirLivroDeColecao();
                        break;
                    case "5":
                        ExcluirColecaoDaBiblioteca();
                        break;
                    case "6":
                        ExibirPerfil();
                        break;
                    case "7":
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void ExcluirColecaoDaBiblioteca()
        {
            Console.WriteLine("Exclusão de Coleção");
            Console.Write("Digite o nome da Coleção: ");
            string nome = Console.ReadLine();


            Colecao colecaoParaRemover = Biblioteca.Colecoes.FirstOrDefault(c => c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            if (colecaoParaRemover != null)
            {

                Biblioteca.Colecoes.Remove(colecaoParaRemover);
                Console.WriteLine($"Coleção '{nome}' removida com sucesso da biblioteca.");
            }
            else
            {
                Console.WriteLine($"Coleção '{nome}' não encontrada na biblioteca.");
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }

            private static void ExcluirLivroDeColecao()
            {
                Console.WriteLine("Exclusão de Livro de Coleção");
                Console.Write("Digite o título do Livro: ");
                string titulo = Console.ReadLine();

                Livro livroParaExcluir = Biblioteca.BuscarLivro(titulo);

                if (livroParaExcluir != null)
                {
                    Colecao colecaoDoLivro = null;
                    foreach (var colecao in Biblioteca.Colecoes)
                    {
                        if (colecao.Livros.Contains(livroParaExcluir))
                        {
                            colecaoDoLivro = colecao;
                            break;
                        }
                    }

                    if (colecaoDoLivro != null)
                    {
                        colecaoDoLivro.RemoverLivro(livroParaExcluir);
                        Console.WriteLine($"Livro '{titulo}' removido da coleção '{colecaoDoLivro.Nome}'.");
                    }
                    else
                    {
                        Console.WriteLine($"Erro: O livro '{titulo}' não está em nenhuma coleção.");
                    }
                }
                else
                {
                    Console.WriteLine($"Livro '{titulo}' não encontrado na biblioteca.");
                }

                Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                Console.ReadKey();
            }


        private static void MenuAssociado(Usuario associado)
        {
            bool executando = true;
            while (executando)
            {
                Console.Clear();
                Console.WriteLine("Bem-vindo à Biblioteca!");
                Console.WriteLine("1. Mostrar Catálogo");
                Console.WriteLine("2. Abrir Empréstimos");
                Console.WriteLine("3. Abrir Dados dos Autores");
                Console.WriteLine("4. Perfil");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        MostrarCatalogo();
                        break;
                    case "2":
                        AbrirEmprestimos();
                        break;
                    case "3":
                        AbrirDadosAutores();
                        break;
                    case "4":
                        ExibirPerfil();
                        break;
                    case "5":
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private static void MostrarCatalogo()
        {
            Console.Clear();
            Console.WriteLine("Catálogo de Livros:");
            foreach (var colecao in Biblioteca.Colecoes)
            {
                Console.WriteLine($"Coleção: {colecao.Nome}");
                foreach (var livro in colecao.Livros)
                {
                    Console.WriteLine($"- {livro.Titulo}, ISBN: {livro.ISBN})");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }

        private static void AbrirEmprestimos()
        {
            Console.Clear();
            Console.WriteLine("Empréstimos:");

            if (FuncionarioPrincipal is Funcionario)
            {
                foreach (var associado in Biblioteca.Associados)
                {
                    Console.WriteLine($"Associado: {associado.Nome}");
                    foreach (var emprestimo in associado.Emprestimos)
                    {
                        Console.WriteLine($"- Livro: {emprestimo.Livro.Titulo} (Data de Empréstimo: {emprestimo.DataEmprestimo.ToShortDateString()})");
                    }
                    Console.WriteLine();
                }
            }
            else if (FuncionarioPrincipal is Associado associadoLogado)
            {
                Console.WriteLine($"Empréstimos de {associadoLogado.Nome}:");
                foreach (var emprestimo in associadoLogado.Emprestimos)
                {
                    Console.WriteLine($"- Livro: {emprestimo.Livro.Titulo} (Data de Empréstimo: {emprestimo.DataEmprestimo.ToShortDateString()})");
                }
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }


        private static void AbrirDadosAutores()
        {
            Console.Clear();
            Console.WriteLine("Dados dos Autores:");

            var autores = Biblioteca.Colecoes
                .SelectMany(c => c.Livros)
                .SelectMany(l => l.Autores)
                .Distinct()
                .ToList();

            foreach (var autor in autores)
            {
                Console.WriteLine($"Autor: {autor.Nome}");

                var livrosDoAutor = Biblioteca.Colecoes
                    .SelectMany(c => c.Livros)
                    .Where(l => l.Autores.Any(a => a.Nome == autor.Nome))
                    .ToList();

                foreach (var livro in livrosDoAutor)
                {
                    Console.WriteLine($"- Livro: {livro.Titulo} (ISBN: {livro.ISBN})");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }

        private static void ExibirPerfil()
        {
            Console.Clear();

            if (FuncionarioPrincipal is Funcionario funcionario)
            {
                Console.WriteLine("Perfil do Funcionário:");
                Console.WriteLine($"Nome: {funcionario.Nome}");
                Console.WriteLine($"Email: {funcionario.Email}");

                if (!string.IsNullOrEmpty(funcionario.Cargo))
                {
                    Console.WriteLine($"Cargo: {funcionario.Cargo}");
                }

                if (funcionario is Funcionario)
                {
                    Console.WriteLine($"Salário: {funcionario.Salario.ToString("C2")}");
                }
            }
            else if (FuncionarioPrincipal is Associado associado)
            {
                Console.WriteLine("Perfil do Associado:");
                Console.WriteLine($"Nome: {associado.Nome}");
                Console.WriteLine($"Email: {associado.Email}");
            }

            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }

    }
}
