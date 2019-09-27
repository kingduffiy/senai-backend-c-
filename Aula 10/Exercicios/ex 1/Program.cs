using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;
            double porcentagem;

            System.Console.WriteLine ("Digite o valor:");
            valor = double.Parse (Console.ReadLine());

            System.Console.WriteLine("Digite a porcentagem do desconto:");
            porcentagem = double.Parse(Console.ReadLine());

            System.Console.WriteLine(desconto(valor, porcentagem));
        }
        static double desconto (double valor, double porcentagem){
            

            valor = valor - (valor * porcentagem / 100);

            return valor;
            
            
            }
    }
}
