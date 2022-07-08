using System;
using System.Collections.Generic;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            var valores = new List<int>() { 1, 2, 4, 5, 8, 26, 23 };
            int soma =0;

            for (int i = 1; i <=10; i++) {

                if (i % 2 == 0) 
                {
                    soma +=i;
                    //soma = soma + i;
                }
            }

            Console.WriteLine("A soma dos números pares é: " +soma.ToString());


            //40
        }
    }
}
