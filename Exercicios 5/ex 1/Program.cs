using System;

namespace Exercicios_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] valores = new double[10];
            

            for(int i = 0; i <= 9; i++){
                Console.WriteLine("Digite um valor: ");
                valores[i] = double.Parse(Console.ReadLine());
            }
            for(int i = 0; i <= 9; i++){
                Console.WriteLine(valores[i]);
            }
            valores[9] = valores[9] * 5;
            Console.WriteLine(valores[9]);
            
            }
        }
    }

