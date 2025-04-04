using System;
using System.ComponentModel.DataAnnotations;

namespace AvaliacaoSatisfacaoUnisagrado.Models
{
    public class Avaliacao
    {
        public int Id { get; set; }

        [Required]
        public string Setor { get; set; }

        public string? Atendente { get; set; }

        [Required]
        [Range(1, 5)]
        public int Nota { get; set; }

        public string? Comentario { get; set; }

        public DateTime DataHora { get; set; } = DateTime.Now;
    }
}
