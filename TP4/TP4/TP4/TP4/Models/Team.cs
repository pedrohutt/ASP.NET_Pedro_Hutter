namespace TP4.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Estado { get; set; }
        public DateTime Criacao { get; set; }
        public int TitulosBR { get; set; }
    }
}
