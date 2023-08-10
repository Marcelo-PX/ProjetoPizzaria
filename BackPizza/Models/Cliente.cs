namespace Pizzaria.Models
{
    public class Cliente
    {
        public Cliente() => DataCadastro = DateTime.Now;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public DateTime DataCadastro { get; set; }
        
    }
}