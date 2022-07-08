using System;
using System.Collections.Generic;

namespace ModeloSoma
{
    class Program
    {
        static void Main(string[] args)
        {
            var valores = new List<int>() { 1, 2, 4, 5, 8, 26, 23, 4, 2, 10, 5, 1, 7 };//56
            int soma = 0;

            for (int i = 0; i < valores.Count; i++) {
                if (valores[i] % 2 == 0) {
                    soma += valores[i];
                }
            }

            Console.WriteLine("Soma dos numeros pares são: "+soma.ToString());
        }
    }
}
