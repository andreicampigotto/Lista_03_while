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

            Console.Write("Digite quantos carros deseja cadastrar: ");
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
                int mediaAnoCarros = anoCarro / qtdacarros;
                double mediaValorCarros = valorCarro / qtdacarros;

                if (primeiraLetra == 'G') 
                {
                    int carrosG = 0;
                    carrosG = carrosG + 1; 
                }
                else if (primeiraLetra == 'A')
                {
                    int carrosA = 0;
                    carrosA = carrosA + 1;
                }
            Console.WriteLine("Média de anos dos carros: " + mediaAnoCarros +
                "\n Média dos valores dos carros" + mediaValorCarros 
                /*"\n Quantidade de carros que começam com G: " + carrosc*/);
            }

        }
    }
}


