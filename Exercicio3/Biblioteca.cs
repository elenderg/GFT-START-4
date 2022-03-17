using MyApplication;
using System;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro primeiroLivro = new Livro("Patriarcas e Profetas", 900);
            Livro segundoLivro = new Livro("Profetas e Reis", 300);

            Leitor leitor = new Leitor("Elender", segundoLivro);
            leitor.adicionarLivro(primeiroLivro);

            primeiroLivro.adicionarPaginasLidas(36);
            segundoLivro.adicionarPaginasLidas(48);
            mostrarEstatisticas();

            Console.WriteLine("_________________________________");
            Console.WriteLine(" ");
            Console.WriteLine("Alterando o número de páginas Lidas ...");
            Console.WriteLine("_________________________________");
            primeiroLivro.adicionarPaginasLidas(12);
            segundoLivro.adicionarPaginasLidas(96);
            mostrarEstatisticas();

            Console.WriteLine("_________________________________");
            Console.WriteLine(" ");
            Console.WriteLine($"Removendo {primeiroLivro.titulo}...");
            Console.WriteLine("_________________________________");
            leitor.removerLivro(primeiroLivro);
            mostrarEstatisticas();


            void mostrarEstatisticas()
            {
                Console.WriteLine("_________________________________");
                Console.WriteLine(" ");
                Console.WriteLine($"Estatísticas dos Livros do {leitor.nome}");
                Console.WriteLine($"Quantidades de Livros na Estante{leitor.estanteLivros.Count}");
                Console.WriteLine($"Progresso de Leitura {primeiroLivro.titulo}: {primeiroLivro.verificarProgresso()}%");
                Console.WriteLine($"Progresso de Leitura {segundoLivro.titulo}: {segundoLivro.verificarProgresso()}%");
                Console.WriteLine("__________________________________");

            }
        }


    }
}