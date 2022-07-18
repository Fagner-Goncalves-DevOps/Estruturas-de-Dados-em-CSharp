using System;

namespace Dados37
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# que cria a árvore da página 137.O programa deve exibir na tela os três tipos de caminhamentos.

            Tree a1 = new Tree(null, 'd', null);
            Tree a2 = new Tree(null, 'e', null);
            Tree a3 = new Tree(null, 'b', a2);
            Tree a4 = new Tree(null, 'g', null);
            Tree a5 = new Tree(  a4, 'f', null);
            Tree a6 = new Tree(null, 'c', a5);
            Tree a = new Tree(   a3, 'a', a6);

            Console.WriteLine("Caminhamentos em Arvores");
            Console.Write("Pré-Ordem:");
            caminhamentoPreOrdem(a);
            Console.Write("\n In-Fixado: ");
            caminhamentoInFixado(a);
            Console.Write("\n Pos-Fixado");
            caminhamentoPosFixado(a);
            Console.WriteLine();
        }

        // --------------------------------------------- caminhamentoPreOrdem
        static void caminhamentoPreOrdem(Tree a) 
        {
            if (!treeVazia(a))
            {
                Console.Write(a.info + " "); //mostrar a raiz
                caminhamentoPreOrdem(a.esq); //mostra sub_esquerda
                caminhamentoPreOrdem(a.dir); //mostra sub_dir
            }
        }

        // --------------------------------------------- caminhamentoInFixado
        static void caminhamentoInFixado(Tree a) 
        {
            if (!treeVazia(a)) 
            {
                caminhamentoInFixado(a.esq);   //mostra sub esquerda
                Console.Write(a.esq);         // mostra sub esquerda
                caminhamentoInFixado(a.dir); //  mostra sub direita
            }
        }

        // --------------------------------------------- caminhamentoPosFixado
        static void caminhamentoPosFixado(Tree a) 
        {
            if (!treeVazia(a)) 
            {
                caminhamentoPosFixado(a.esq); //mostra sub esquerda
                caminhamentoPosFixado(a.dir); //mostra sub direta
                Console.Write(a.info + " "); // mostra raiz
            }
        }


        // --------------------------------------------- treeVazia
        static bool treeVazia(Tree a) 
        {
            if (a == null)
            {
                return (true);
            }else { return (false); 
            }
        }
    }
}
