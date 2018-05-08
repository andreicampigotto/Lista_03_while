using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_03_while
{
    class Exercicio07
    {
        public Exercicio07()
        {
            int quatidadeAtletas = 0;
            string nomes = " ";
            Console.Write("Digite o nome do atleta: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o sexo: ");
            char sexo = Convert.ToChar(Console.ReadLine().ToLower());

            Console.Write("Digite a altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de gols marcados: ");
            int golsMarcados = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de cartões amarelos recebidosa: ");
            int cartaoAmaelo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de cartões vermelhos: ");
            int cartaoVermelho = Convert.ToInt32(Console.ReadLine());
            quatidadeAtletas = quatidadeAtletas + 1;

            while (quatidadeAtletas < 23)
            {
               
            }


        }
    }
}
