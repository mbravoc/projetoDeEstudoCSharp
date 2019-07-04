using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto de conversão");

            double salario = 1200.50;
            Console.WriteLine("Salario em double: " + salario);

            // A variavel int suporta 32 bits
            int salarioEmInteiro = (int)salario;
            Console.WriteLine("salario em inteiro: " + salarioEmInteiro);

            // A variavel long suporta 64 bits
            long idade = 100000000000;
            Console.WriteLine("Variavel Long: " + idade);

            // A variavel short suporta 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine("Variavel Short: " + quantidadeProdutos);

            float altura = 1.80F;
            Console.WriteLine("Variavel Float: " + altura);
                
            Console.ReadLine();

        }
    }
}
