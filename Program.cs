using System;

namespace EstruturasDeRepeticao
{
    public class EstruturasRepeticao 
    {
        public static void Main(string[] args)
        {
            int numero = 2;

            for(int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            }
        }
    }
}