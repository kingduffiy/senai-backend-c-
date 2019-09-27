using System;
using System.Linq;

namespace ex_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = {4,9,4,2};
            System.Console.WriteLine($"Seu valor total é: {ValorTotal(num)}");
        }

        static double ValorTotal(double[] numeros){
            return numeros.Sum();
        }
    }
}
