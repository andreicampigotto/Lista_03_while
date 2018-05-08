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
            Console.Write("Digite o nome do atleta: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade do atleta: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o peso do atleta: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o sexo do atleta: ");
            char sexo = Convert.ToChar(Console.ReadLine().ToLower());

            Console.Write("Digite a altura do atleta: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine();

        }
    }
}
