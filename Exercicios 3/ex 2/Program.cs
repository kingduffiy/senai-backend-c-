using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso;
            int num;
            double resultado;

            Console.Write("Digite seu peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.Write("Digite o número do planeta: ");
            num = int.Parse(Console.ReadLine());



            if(num == 1){
                resultado = (peso / 10) * 0.37f;
                Console.WriteLine(resultado);
            }else if(num == 2){
                resultado = (peso / 10) * 0.88f;
                Console.WriteLine(resultado);
            }else if(num == 3){
                resultado = (peso / 10) * 0.38f;
                Console.WriteLine(resultado);
            }else if(num == 4){
                resultado = (peso / 10) * 2.64f;
                Console.WriteLine(resultado);
            }else if(num == 5){
                resultado = (peso / 10) * 1.15f;
                Console.WriteLine(resultado);
            }else if(num == 6){
                resultado = (peso / 10) * 1.17f;
                Console.WriteLine(resultado);
            }else{
                Console.WriteLine("numero invalido");
            }
            
            

        }
    }
}
