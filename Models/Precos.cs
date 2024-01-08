using System.ComponentModel.DataAnnotations;

namespace GestaoEstacionamentoRotativo.Models{

    public class Precos{

        public int Id { get; set; }

        [Required]
        public TimeSpan Time { get; set; }

        [Required]
        public int CategoriaVeiculoId { get; set; }

        public virtual VeiculoCategoria? Cateigoria { get; set; }
    }
}