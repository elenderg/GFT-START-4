using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Digite os números : ");                     
           int[] Numeros = Array.ConvertAll(Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries), (item) => Convert.ToInt32(item));
           if (Numeros.Length == 0) // verifica se o array está vazio, isto é, se nenhum dado foi informado
           {
               Console.WriteLine("Erro. Nenhum valor informado"); 
                return; // sai da função e fecha o programa
            }
           int Soma = 0, MaiorNumero = Numeros[0];
           foreach (int numero in Numeros)  
           {  
               Soma = Soma + numero;               
           }
           for(int i = 1; i < Numeros.Length; ++i)
           {
               if(Numeros[i] > MaiorNumero)
               {
                   MaiorNumero = Numeros[i];
               }
            }  
            Console.WriteLine("O maior número é : " + MaiorNumero);
            Console.WriteLine("A soma dos valores é : " + Soma);
        
        }
    }
}