using System;

namespace Dados7a
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
                    demonstra a.
                    construção de uma lista de m elementos ordenados diretamente.
                    na entrada dos dados.O programa possui uma classe.
                    ListaOrdenada.
           */ 

            const int SUCESSO = 0;
            const int LISTA_CHEIA = 1;
            const int LISTA_VAZIA = 2;

            ListaOrdenada lista = new ListaOrdenada(7);

            int valor;
            int erro = 0;

            Console.Write("Elemento: ");
            string s = Console.ReadLine();
            valor = Convert.ToInt32(s);

            if (valor != 0) {
                erro = lista.incluiInic(valor);
                do {
                    Console.Write("Elemento: ");
                    s = Console.ReadLine();
                    valor = Convert.ToInt32(s);
                    if (valor != 0) {
                        erro = lista.verificaPos(valor);
                        if (erro == LISTA_CHEIA) {
                            Console.WriteLine("Erro: Lista Cheia");
                            lista.exibeLista();
                            return;
                        }
                    }
                } while (valor != 0);
            }
            lista.exibeLista();
        }
    }
}
