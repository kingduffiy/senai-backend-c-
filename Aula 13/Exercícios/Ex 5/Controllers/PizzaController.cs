using System;
using Ex_5_lista.Models;

namespace Ex_5_lista.Controllers
{
    public class PizzaController
    {
        PizzaModel info = new PizzaModel();

        public void InfoPizza(){
            System.Console.WriteLine("A pizza será doce ou salgada?");
            info.Tipo = Console.ReadLine();

            System.Console.WriteLine("Nome da pizza: ");
            info.Nome = Console.ReadLine();
            
            System.Console.WriteLine("Preço da pizza: ");
            info.Preco = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Tamanho da pizza: ");
            info.Tamanho = Console.ReadLine();

            System.Console.WriteLine($"Pedido final: \nPizza {info.Tipo} | {info.Nome} | {info.Preco} | {info.Tamanho}");
            
            
        }
    }
}