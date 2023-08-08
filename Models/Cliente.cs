namespace Pizzaria.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Nascimento { get; set; }
        public string CriadoEm { get; set; }
        
    }
}