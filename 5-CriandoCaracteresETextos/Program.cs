﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CriandoCaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando o Projeto Caracteres E Textos");

            char primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura, Cursos de Tecnologia " + 2020;
            Console.WriteLine(titulo);

            string cursosProgramacao = 
@"- .NET 
- JAVA 
- JSCRIPT";
            Console.WriteLine(cursosProgramacao);
            


            Console.ReadLine();
        }
    }
}
