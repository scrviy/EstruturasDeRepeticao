﻿using System;

namespace EstruturasDeRepeticao
{
    public class EstruturasRepeticao 
    {
        public static void Main(string[] args)
        { /*
            //loop for /*
            int numero = 5;
            for(int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            } */ 

            //loop while
            int number = 5;
            int count = 0;

            while (count <= 10)
            {
                Console.WriteLine($"{count}˚ Execução: {number} x {count} = {number * count}");
                count++;
            }
        }
    }
}