namespace Pizzaria.Models
{
    public class Pedido
    {
        public Pedido() => DataPedido = DateTime.Now;
        public DateTime DataPedido { get; set; }
        public int Id { get; set; }

        // Relacionamento Cliente <-> Pedido <-> Pizza
        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public Pizza Pizza { get; set; }
        public int PizzaId { get; set; }

    }
}