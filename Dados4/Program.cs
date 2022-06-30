using System;

namespace Dados4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ordenar valores inteiros positivos - usando força bruta

            int[] vetor = { 5,40,20,10,50,30}; //5 é numero de elementos dentro do vetor

            Console.Write("Vetor de Entrada:");

            for (int i = 0; i < vetor.Length; i++) {
                Console.WriteLine(vetor[i] + " ");
            }
            Console.WriteLine();

            for (int i = 1; i < vetor[0]; i++) {
                for (int j = i + 1; j <= vetor[0]; j++) {
                    if (vetor[i] > vetor[j]) {
                        int temp = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = temp;
                    }
                }      
            }
            Console.WriteLine("Vetor Ordenado:");

            for (int i = 1; i < vetor.Length; i++) {
                Console.WriteLine(vetor[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Numero de Elementos: " + vetor[0]);
        }
    }
}
