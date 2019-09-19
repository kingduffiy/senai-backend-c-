using System;

namespace Exercicios_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string pedido;
            string resultado;

            Console.Write("Digite o número do pedido: ");
            pedido = Console.ReadLine();

            if(pedido == "1"){
                resultado = "Hamburguer";
            }else if(pedido == "2"){
                resultado = "Cheese Salada";
            }else if(pedido == "3"){
                resultado = "Cheese burguer";
            }else if(pedido == "4"){
                resultado = "Cheese Bacon";
            }else{
                resultado = "Opcão inválida";
            }
            Console.WriteLine(resultado);

        }
    }
}
