﻿namespace Domain
{
    public class Team
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Nome { get; set; }
        public string? Estado { get; set; }
        public int TitulosBrasileiros { get; set; }
        public int TitulosEstaduais { get; set; }
        public DateOnly DataCriacao { get; set; }

        public int TempoAtivo()
        {
            int now = DateTime.Now.Year;
            int dataCriacao = now - DataCriacao.Year;
            return dataCriacao;
        }
    }
}