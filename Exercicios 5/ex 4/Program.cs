using System;

namespace ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = new string[2];
            string[] b = new string[2];
            for(int i = 0; i <= 1; i++){
                Console.WriteLine("Insira uma palavra: ");
                a[i] = Console.ReadLine();
            }
            for(int i = 0; i <= 1; i++){
                Console.WriteLine("Insira uma palavra: ");
                b[i] = Console.ReadLine();
            }for(int i = 0; i <= 3; i++)
            Console.WriteLine($"A: {a[i]}\n B:{b[i]}\n");
        }
    }
}
