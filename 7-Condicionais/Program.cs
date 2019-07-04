using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando o projeto condicionais");

            int idadeJoao = 16;
            int quantidadePessoas = 2;


            if (idadeJoao >= 18)
            {

                Console.WriteLine("Joao está autorizado!");

            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("Joao tem menos de 18, porém acompanhado, está autorizado!");
                }
                else
                {
                    Console.WriteLine("Joao não está autorizado");
                }

            }


            Console.ReadLine();
        }
    }
}
