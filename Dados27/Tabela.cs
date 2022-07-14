using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados27
{
    public class Tabela
    {
        private int[] chave;
        private string[] nome;
        private double[] peso;
        private double[] altura;
        private int n = -1;
        private int max;

        // ---------------------------------------------- construtor
        public Tabela(int numElementos) 
        {
            chave = new int[numElementos];
            nome = new string[numElementos];
            peso = new double[numElementos];
            altura = new double[numElementos];
            n = -1;
            max = numElementos;
        }
        // ---------------------------------------------- pesquisaSequencial
        public int pesquisaSequencial(int ch) 
        {
            int key = -1;

            for (int i = 0; i <= n; i++) {
                if (chave[i] == ch) {
                    key = i;
                    break;
                }
            }
            return (key);
        }
        // ---------------------------------------------- exibeTabela
        public void exibeTabela(int key) 
        {
            if (key != -1)
            {
                Console.WriteLine("Chave: " + chave[key]);
                Console.WriteLine("Nome: " + nome[key]);
                Console.WriteLine("Peso: " + peso[key]);
                Console.WriteLine("Altura: " + altura[key]);
            }
            else {
                Console.WriteLine("Erro: Chave inexistente!");
            }
        }
        // ---------------------------------------------- entradaTabela
        public void entradaTabela() 
        {
            string s;
            char tecla;

            do
            {
                n++;
                Console.Write("Chave: ");
                s = Console.ReadLine();
                chave[n] = Convert.ToInt32(s);
                if (chave[n] == 0) Environment.Exit(0);

                Console.Write("Nome: ");
                nome[n] = Console.ReadLine();
                Console.Write("Peso: ");
                s = Console.ReadLine();
                peso[n] = Convert.ToInt32(s);
                Console.Write("Altura: ");
                s = Console.ReadLine();
                altura[n] = Convert.ToDouble(s);

                Console.Write("Continua [s/n] ?");
                do
                {
                    s = Console.ReadLine();
                    s = s.ToLower();
                    tecla = s[0];
                } while (tecla != 's' && tecla != 'n');

            } while (tecla == 's' && n < max);
        }
    }
}
