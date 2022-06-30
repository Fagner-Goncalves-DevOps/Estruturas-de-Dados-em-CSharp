using System;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
        //Aritméticos

        /*
            +  Adição
            -  Subtração
            *  Multiplicação
            /  Divisão
            %  Resto Inteiro da Divisão
            ++ Incremento
            -- Decremento

            */

        //Relacionais
        //comandos que possuem “condição”.
        // fazer comparações

        /*
            > Maior
            < Menor
            >= Maior ou Igual
            <= Menor ou Igual
            == Igual
            != Diferente
        */

        //Lógicos

        /*
            && e
            || ou
            ! não
        */

        //Exemplo: c# condições sempre tem resultado true ou false
            bool chuvendo = true;

            if (!chuvendo)
            {
                Console.WriteLine("Está chuvendo");
            }
            else
            {
                Console.WriteLine("Não está chuvendo");
            }
            //resultado não esta chovendo
        }
    }
    }
}
