using System;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[12];
            string[] cor = new string[12];
            string[] tamanho = new string[12];
            double[] preco = new double[12];

            for(int i = 0; i <= 11; i++){
                Console.WriteLine("Digite o nome do Produto: ");
                nome[i] = Console.ReadLine();
            }
            for(int i = 0; i <= 11; i++){
                Console.WriteLine("Digite a cor do Produto: ");
                cor[i] = Console.ReadLine();
            }
            for(int i = 0; i <= 11; i++){
                Console.WriteLine("Digite o tamanho do Produto: ");
                tamanho[i] = Console.ReadLine();
            }
            for(int i = 0; i <= 11; i++){
                Console.WriteLine("Digite o preço do Produto: ");
                preco[i] = double.Parse(Console.ReadLine());
            }
            for(int i = 0; i <= 11; i++){
                Console.WriteLine($"Nome: {nome[i]}\n Cor: {cor[i]}\n Tamanho: {tamanho[i]}\n Preço: {preco[i]}\n ");}
        }
    }
}
