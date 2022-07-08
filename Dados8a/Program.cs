using System;

namespace Dados8a
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                * demonstra a
                construção de uma lista de m elementos ordenados e SEM
                REPETIÇÃO diretamente na entrada dos dados. O programa possui
                uma classe ListaSemRepeticao.
            */

            const int SUCESSO = 0;
            const int LISTA_CHEIA = 1;
            const int LISTA_VAZIA = 2;
            const int REPETIDO = 3;

            ListaSemRepeticao lista = new ListaSemRepeticao(7);
            int valor;
            int erro = 0;


            Console.Write("Elemento: ");
            string s = Console.ReadLine();
            valor = Convert.ToInt32(s);


            if (valor != 0)
            {
                erro = lista.incluiInic(valor);
                do
                {
                    Console.Write("Elemento: ");
                    s = Console.ReadLine();
                    valor = Convert.ToInt32(s);
                    if (valor != 0)
                    {
                        erro = lista.verificaPos(valor);
                        switch (erro) {
                            case REPETIDO:
                                Console.WriteLine("Erro: Elemento REPETIDO");
                                break;
                            case LISTA_CHEIA:
                                Console.WriteLine("Erro:Lista Cheia");
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
