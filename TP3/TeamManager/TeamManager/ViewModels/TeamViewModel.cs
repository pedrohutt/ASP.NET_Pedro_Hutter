﻿namespace TeamManager.ViewModels
{
    public class TeamViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Estado { get; set; }
        public int TitulosBrasileiros { get; set;}
        public int TitulosEstaduais { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
