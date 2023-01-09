using System;

namespace EstruturasDeRepeticao
{
    public class EstruturasRepeticao 
    {
        public static void Main(string[] args)
        {   /*
            //loop for /*
            int numero = 5;
            for(int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            } 

            //loop while
            int number = 5;
            int count = 1;

            while (count <= 10)
            {
                Console.WriteLine($"{count}˚ Execução: {number} x {count} = {number * count}");
                count++;

                if(count == 6)
                break;
            }
            */
            
            //No do...while executa a condicao pelo menos uma vez
            int soma = 0, numero = 0;
            
            do 
            {
                Console.WriteLine("Digite um número: (0 para parar.)");
                
                

            } while(numero != 0);
            Console.WriteLine($"Total da soma dos números digitados é: {soma}");
        
        }   
           }   
}