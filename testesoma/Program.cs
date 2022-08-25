using System;
using System.Collections.Generic;

namespace testesoma
{
    class Program
    {
        //modelo de soma pares, com metodos separados
        static void Main(string[] args)
        {
           var result = somarPares();
            mostrarNaTela(result);
        }
        public static int somarPares() 
        {
            var valores = new List<int>() { 1, 2, 3, 4, 5, 6, 50, 47, 89, 63, 50 };
            int soma = 0;

            for (int i = 0; i < valores.Count; i++)
            {
                if (valores[i] % 2 == 0)
                    soma += valores[i]; 
            }
            return soma;
        }
        public static void mostrarNaTela(int res) 
        {
            int soma = res;
            Console.WriteLine("A Soma de todos numeros pares são:"+soma.ToString());
        }

    }
}
 


