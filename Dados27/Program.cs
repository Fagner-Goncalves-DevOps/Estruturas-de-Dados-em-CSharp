using System;

namespace Dados27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Busca Seqüencial em uma estrutura que possui os campos: chave, nome, altura e peso.
            //O programa demonstra uma busca sequencial em uma tabela.

            Tabela tabela = new Tabela(10);
            int key, chave;

            tabela.entradaTabela();
            do {
                Console.Write("Chave para consulta [0-Sair]: ");
                string s = Console.ReadLine();
                key = Convert.ToInt32(s);
                if (key != 0) {
                    chave = tabela.pesquisaSequencial(key);
                    tabela.exibeTabela(chave);
                }
            } while (key != 0);
        }
    }
}
