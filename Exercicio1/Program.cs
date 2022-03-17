using System;  
  public class InversorDeNumeros  
   {  
     public static void Main(string[] args)  
      {  
       int  NumeroOriginal, NumeroInvertido = 0, NumeroDividido;           
       Console.Write("Digite um número para ser invertido: ");      
       NumeroOriginal= int.Parse(Console.ReadLine()); // Lê o número a ser invertido
       while(NumeroOriginal > 0)  // verifica se o número é diferente de zero    
       {      
        NumeroDividido = NumeroOriginal % 10; // Obtém o módulo da divisão do número por 10        
        NumeroInvertido = NumeroInvertido * 10 + NumeroDividido; // Multiplica o valor anterior e atribui ao valor      
        NumeroOriginal /= 10;   //  NumeroOriginal = NumeroOriginal / 10
       }      
       Console.Write("O Número Invertido fica assim: " + NumeroInvertido ) ;       
    }  
  }  