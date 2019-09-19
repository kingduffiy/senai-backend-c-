using System;

namespace Exercicios_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, despesa, resultado;
            string retorno;
            
            Console.Write("Digite seu salário: ");
            salario = float.Parse (Console.ReadLine() );

            Console.Write("Digite sua despesa total: ");
            despesa = float.Parse (Console.ReadLine() );

            resultado = salario - despesa;

            if(resultado < 0){

                retorno = "Déficit";

            }else{

                retorno = "Superávit";

            }
            Console.WriteLine($"Sua situação é {retorno}");
        }
    }
}
