using System;
using Ex_5_lista.Models;

namespace Ex_5_lista.Controllers
{
    public class PedidoController
    {
        PedidoModel Pedido = new PedidoModel();

        
        public void LerPedido(){
            
            System.Console.WriteLine("Coloque o seu endereço:");
            Pedido.EnderecoDeEntrega = Console.ReadLine();
            
            
            var Data = DateTime.Now;
            var Entrega = DateTime.Now.AddMinutes(30);
            
            System.Console.WriteLine("Data do pedido:");
            System.Console.WriteLine(Data);

            System.Console.WriteLine("Previsão de Entrega:");
            System.Console.WriteLine(Entrega);
            
            System.Console.WriteLine("A pizzaria PAPA PIZZA agradece sua compra, seu infeliz !");

            
        }
    }
}