using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
   class Ex1
    {
        static void Main(string[] args)
        {

            int INDICE = 13, SOMA = 0, K = 0;

            while (K < INDICE)
            {

                K = K + 1;

                SOMA = SOMA + K;

            }
            Console.WriteLine(SOMA);

            Console.ReadLine();
            // A Soma sera de 91
        }
    }

}
