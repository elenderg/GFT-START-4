using System;
 // mudar isso aqui

namespace Exercicio4
{
    class Programa
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente("Elender", 31 , 2500);
            Supervisor supervisor = new Supervisor("Gois", 42 , 1500);
            Vendedor vendedor = new Vendedor("Galas", 23, 1000);

            Console.WriteLine("\n Informações dos Pagamentos de Funcionários ");
            Console.WriteLine($"Funcionário: {gerente.Nome}, Idade: {gerente.Idade}, Salário: {(gerente.Salario):C2} e Bonificação: {gerente.bonificacao(gerente.Salario):C2}");
            Console.WriteLine("-------------------------------------------------------------------------------------");            
            Console.WriteLine($"Funcionário {supervisor.Nome}, Idade: {supervisor.Idade}, Salário: {(supervisor.Salario):C2} e Bonificação: {supervisor.bonificacao(supervisor.Salario):C2}");
            Console.WriteLine("-------------------------------------------------------------------------------------");     
            Console.WriteLine($"Funcionário {vendedor.Nome}, Idade: {vendedor.Idade}, Salário: {(vendedor.Salario):C2} e Bonificação: {vendedor.bonificacao(vendedor.Salario):C2}"); 
            Console.WriteLine("-------------------------------------------------------------------------------------");       
        }
    }
}