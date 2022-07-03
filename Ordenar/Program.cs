using System;

namespace Ordenar
{
    class Program
    {
        static void Main(string[] args)
        {
            //inserir numeros inteiros, maximo 5 elementos me um vetor mantendo ordenado, quando usuario digitar zero o programa deve imprimir.

            Vetor vetor = new Vetor(5);
            int elemento;

            do
            {
                Console.Write("Elemento: ");

                string s = Console.ReadLine();
                elemento = Convert.ToInt32(s);
                if (elemento != 0)
                {
                    vetor.verificaPosicao(elemento);
                }
                vetor.exibeVetor();
            } while (elemento != 0);
        }
    }
}
