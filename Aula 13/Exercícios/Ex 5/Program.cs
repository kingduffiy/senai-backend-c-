using System;
using Ex_5_lista.Controllers;

namespace Ex_5_lista
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaController info = new PizzaController();
            PedidoController Pedido = new PedidoController();

            info.InfoPizza();
            Pedido.LerPedido();

        }
    }
}
