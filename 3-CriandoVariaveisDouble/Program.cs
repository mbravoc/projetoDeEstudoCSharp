﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando Projeto, Variaveis Double");

            double salario;
            salario = 1200.70;

            Console.WriteLine("seu salário é: " + salario);

            double idade;
            idade = 15.0 / 2;
            Console.WriteLine("15.0 / 2 = " + idade);

            idade = 15 / 2;
            Console.WriteLine("15 / 2 = " + idade);

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);



            Console.WriteLine("A execução acabou, tecle enter para sair");
            Console.ReadLine();
        }
    }
}
