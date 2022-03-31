namespace AT_TeamManager.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public int TitulosBrasileiros { get; set; }
        public DateTime Nascimento { get; set; }

        public int? TeamId { get; set; }
        public Team? Team { get; set; }
    }
}
