using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio
{
    class Program
    {
        static void Main(String []args)
        {
            double salario = 3751.2;

            if (salario >1900 && salario < 2800.0)
                Console.WriteLine("o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142");

            else if(salario > 2800.1 && salario < 3751)
                Console.WriteLine("o IR é de 15% e pode deduzir R$ 350");

            else if(salario > 3751.1 && salario < 4664)
                Console.WriteLine("o IR é de 22.5% e pode deduzir R$ 636");
            else
            {
                Console.WriteLine("Nao é necessário deduzir IR");
            }





            Console.ReadLine();
        }


    }

}
