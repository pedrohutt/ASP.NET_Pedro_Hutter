namespace AT_TeamManager.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int TitulosBrasileiros { get; set; }
        public DateTime DataCriacao { get; set; }
        public IList<Player>? Players { get; set; }
    }
}
