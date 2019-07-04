using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando o projeto condicionais");

            int idadeJoao = 18;
            int quantidadePessoas = 2;

            bool acompanhado = quantidadePessoas >= 2;

            if (idadeJoao >= 18 && acompanhado == true)
            {

                Console.WriteLine("Joao está autorizado!");

            }
            else
            {

                Console.WriteLine("Joao não está autorizado");

            }



            Console.ReadLine();
        }
    }
}
