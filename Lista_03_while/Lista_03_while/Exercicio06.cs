﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lista_03_while
{
    class Exercicio06
    {
        public Exercicio06()
        {
            int opcao = 0;
            int bolos = 0;
            int doces = 0;
            int sanduiches = 0;
            int pizzas = 0;
            double somaProdutos = 0;
            double valor = 0;

            Console.WriteLine(
@" CARDÁPIO PADARIA DO JOÃO 
 --------------------------------------------------------------------
| CÓDIGO |    TIPO    |               NOME                |  VALOR   |
|--------------------------------------------------------------------|
|    1   |    BOLOS   | BOLO BRIGADEIRO                   |R$  29,50 |
|--------------------------------------------------------------------|
|    2   |    BOLOS   | BOLO FLORESTA NEGRA               |R$   2,00 |
|--------------------------------------------------------------------|
|    3   |    BOLOS   | BOLO LEITE COM NUTELLA            |R$  29,23 |
|--------------------------------------------------------------------|
|    4   |    BOLOS   | BOLO MOUSSE DE CHOCOLATE          |R$   7,10 |
|--------------------------------------------------------------------|
|    5   |    BOLOS   | BOLO NEGA MALUCA                  |R$  19,33 |
|--------------------------------------------------------------------|
|    6   |    DOCES   | BOMBA CREME                       |R$  17,71 |
|--------------------------------------------------------------------|
|    7   |    DOCES   | BOMBA MORANGO                     |R$   4,82 |
|--------------------------------------------------------------------|
|    8   | SANDUÍCHES | FILÉ-MINGNON COM FRITAS E CHEDDAR |R$  21,16 |
|--------------------------------------------------------------------|
|    9   | SANDUÍCHES | HAMBURGUER COM QUEIJOS,           |R$  12,70 |
|        |            | CHAMPIGNON E RÚCULA                          |
|--------------------------------------------------------------------|
|   10   | SANDUÍCHES | PROVOLONE COM SALAME              |R$  19,70 |
|--------------------------------------------------------------------|
|   11   | SANDUÍCHES | VEGETARIANO DE BERINGELA          |R$  28,22 |
|--------------------------------------------------------------------|
|   12   |   PIZZAS   | CALABRESA                         |R$   8,98 |
|--------------------------------------------------------------------|
|   13   |   PIZZAS   | NAPOLITANA                        |R$   0,42 |
|--------------------------------------------------------------------|
|   14   |   PIZZAS   | PERUANA                           |R$  18,36 |
|--------------------------------------------------------------------|
|   15   |   PIZZAS   | PORTUGUESA                        |R$  27,50 |
|--------------------------------------------------------------------|
|   16                |               SAIR                           |
 --------------------------------------------------------------------
");
            Console.Write("Escolha uma opção: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            while (opcao > 16 && opcao <0)
            {
                if (opcao == 1)
                {
                    bolos = bolos + 1;


                }
                else if (opcao == 2)
                {

                }

            }
        }
    }
}
