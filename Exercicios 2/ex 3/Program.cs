using System;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado;
            
            Console.Write("Digite um numero inteiro: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite um numero inteiro: ");
            num2 = int.Parse(Console.ReadLine());

            if(num1 > num2){

                resultado = num1;

            }else{
                resultado = num2;
            }
            Console.WriteLine($"Numero maior {resultado}");
        }
    }
}
