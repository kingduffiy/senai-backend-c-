using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float preco1, resultado;

            Console.Write("Digite o preço: ");
            preco1 = float.Parse(Console.ReadLine() );

            if(preco1 > 100 ){
                resultado = preco1 - 25f;
            }else{
                resultado = preco1;
            }
            Console.WriteLine($"Preço total {resultado} ");
        }
    }
}
