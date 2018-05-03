using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_03_while
{
    class Exercicio04
    {
        public Exercicio04()
        {
            int qtdacarros = 0;
            int numcarros = 0;

            Console.Write("Digite quantos carros deseja cadastrar");
            qtdacarros = Convert.ToInt32(Console.ReadLine());

            while (qtdacarros <= numcarros)
            {
                Console.Write("Digite o modelo do carro");
                string modelo = Console.ReadLine();

                char primeiraLetra = modelo[0];

                //string nomeCarro = Console.ReadLine();

                Console.Write("Digite o valor do carro");
                double valorCarro = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o ano do carro");
                int anoCarro = Convert.ToInt32(Console.ReadLine());

                numcarros = numcarros + 1;
            }


        }
    }
}


