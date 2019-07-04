using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("executando o projeto 9-Escopo!");

            int idadeJoao = 18;
            int quantidadePessoas = 2;

            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "e está acompanhado.";
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                mensagemAdicional = "João não está acompanhado";
                Console.WriteLine(mensagemAdicional);
            }

            if (idadeJoao >= 18 && acompanhado == true)
            {

                Console.WriteLine("Joao está autorizado!");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {

                Console.WriteLine("Joao não está autorizado!");

            }



            Console.ReadLine();
        }
    }
}
