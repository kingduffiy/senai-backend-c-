namespace Ex_5_lista.Models
{
    public class PedidoModel
    {
        public int DataPedido { get; set; }

        public PizzaModel pizza { get; set; }

        public string EnderecoDeEntrega { get; set; }

        public float PrevisaoDeEntrega { get; set; }
    }
}