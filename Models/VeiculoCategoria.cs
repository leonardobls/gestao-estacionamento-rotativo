using System.ComponentModel.DataAnnotations;

namespace GestaoEstacionamentoRotativo.Models{

    public class VeiculoCategoria{

        public int Id { get; set; }

        [Required]
        public string? Categoria { get; set; }
    }
}