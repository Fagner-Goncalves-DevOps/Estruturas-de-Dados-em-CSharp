using System;

namespace Dados6a
{
    class Program
    {

        const int SUCESSO = 0;
        const int LISTA_CHEIA = 1;
        const int LISTA_VAZIA = 2;

        static void Main(string[] args)
        {
            /*
             
            construção de uma lista de m elementos, onde o número de
            elementos é armazenado na posição zero do vetor, ou seja, n = v[0]
            O programa possui uma classe Lista.

            */

            Lista lista = new Lista(7);
            int valor;
            int erro = 0;

            do {
                Console.Write("Elementos: ");
                string s = Console.ReadLine();
                valor = Convert.ToInt32(s);

                if (valor != 0)  erro = lista.incluiFim(valor);
                if (erro == LISTA_CHEIA) {
                    Console.WriteLine("Erro:Lista Cheia");
                    lista.exibeLista();
                    return;
                }
            } while (valor != 0);
            lista.exibeLista();
        }
    }
}
