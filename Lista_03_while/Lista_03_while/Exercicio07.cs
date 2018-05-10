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
            string nomes = "";
            string maiorNome = "";
            string menorNome = "usahduisahuidhsauidhuisahduisahdia";
            int idade = 0;
            double peso = 0, maiorPeso = int.MinValue, menorPeso = int.MaxValue;
            char sexo = ' ';
            double altura = 0, maiorAltura = int.MinValue, menorAltura = int.MaxValue;
            int golsMarcados = 0;
            int cartaoAmaelo = 0, maiorCartaoAmarelos = int.MinValue,menorCartaoAmarelos = int.MinValue;
            int cartaoVermelho = 0, maiorCartaoVermelhos = int.MinValue, menorCartaoVermelhos = int.MinValue;
            int sexoM = 0;
            int sexoF = 0;

            Console.Write(" ======================================================= ");
            
            while (quatidadeAtletas < 22)
            {
                Console.Write("\nDigite o nome do atleta: ");
                nomes = Console.ReadLine();

                Console.Write("Digite a idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o sexo\nM para masculino\nF para feminino: ");
                sexo = Convert.ToChar(Console.ReadLine().ToLower());

                Console.Write("Digite a altura: ");
                altura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a quantidade de gols marcados: ");
                golsMarcados = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a quantidade de cartões amarelos recebidos: ");
                cartaoAmaelo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite a quantidade de cartões vermelhos recebidos: ");
                cartaoVermelho = Convert.ToInt32(Console.ReadLine());
                quatidadeAtletas = quatidadeAtletas + 1;

                if (nomes.Length > maiorNome.Length)
                {
                    maiorNome = nomes;
                }
                if (nomes.Length < menorNome.Length)
                {
                    menorNome = nomes;
                }
                if (peso < menorPeso)
                {
                    menorPeso = peso;
                }
                if (altura > maiorAltura)
                {
                    maiorAltura = altura;
                }
                if (cartaoAmaelo < menorCartaoAmarelos)
                {
                    menorCartaoAmarelos = cartaoAmaelo;
                }
                if (peso > maiorPeso)
                {
                    maiorPeso = peso;
                }
                if (cartaoVermelho > maiorCartaoVermelhos)
                {
                    maiorCartaoVermelhos = cartaoVermelho;
                }
                if (cartaoAmaelo > maiorCartaoAmarelos)
                {
                    maiorCartaoAmarelos = cartaoAmaelo;
                }
                if (cartaoAmaelo < menorCartaoVermelhos)
                {
                    menorCartaoAmarelos = cartaoAmaelo;
                }

                if (sexo == 'm')
                {
                    sexoM++;
                }
                if (sexo == 'f')
                {
                    sexoF++;
                }
            }
            Console.WriteLine("\nTem " + sexoF + " jogadores do sexo Feminino" +
                              "\nTem " + sexoM + " jogadores do sexo Masculino");
        }
    }
}
