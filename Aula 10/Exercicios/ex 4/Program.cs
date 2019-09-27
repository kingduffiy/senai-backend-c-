using System;
using System.Linq;

namespace ex_4 {
    class Program {
        static void Main (string[] args) {
            double[] num = { 4, 9, 21, 8 };

            System.Console.WriteLine ($"Seu valor é {MaiorNumero(num)}");

        }
        static double MaiorNumero (double[] numeros) {
            return numeros.Max ();

        }
    }
}