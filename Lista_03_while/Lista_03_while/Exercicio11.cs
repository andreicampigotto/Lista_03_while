using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_03_while
{
    class Exercicio11
    {
        public Exercicio11()
        {
            string nome = " ";
            double valor = 0;
            int qtda = 0;



            while (nome.ToLower() != "sair")
            {
                
                Console.Write(
    @"Ao finalizar digite sair.
Digite o nome do prduto: ");
                nome = Console.ReadLine();
                if (nome == "sair")
                {
                    break;
                }
                Console.Write("Digite o valor: ");
                valor = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a quantidade: ");
                qtda = Convert.ToInt32(Console.ReadLine());
            }
                double valorTotal = valor * qtda;
                double desconto = valorTotal * 0.05;
                double valorPagar = valorTotal - desconto;

            Console.WriteLine("Seu total é de: " + valorTotal +
                            "\nSeu desconto é de : " + desconto +
                            "\nValor a pagar: " + valorPagar);
        }
    }
}
