using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados37
{
    public class Tree
    {
        public Tree esq;
        public char info;
        public Tree dir;

        // --------------------------------------------- criaTree
        public Tree(Tree esquerda, char informacao, Tree direta)
        {
            esq = esquerda;
            info = informacao;
            dir = direta;
        }



    }
}
