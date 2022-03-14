using System.ComponentModel;

namespace TeamManager.ViewModels
{
    public class TeamViewModel
    {
        [DisplayName("ID")]
        public Guid Id { get; set; } = Guid.NewGuid();

        [DisplayName("Nome")]
        public string? Name { get; set; }

        [DisplayName("Estado")]
        public string? Estado { get; set; }

        [DisplayName("Titulos Brasileiros")]
        public int TitulosBrasileiros { get; set;}

        [DisplayName("Titulos Estaduais")]
        public int TitulosEstaduais { get; set; }

        [DisplayName("Data de Criação")]
        public DateTime DataCriacao { get; set; }
    }
}
