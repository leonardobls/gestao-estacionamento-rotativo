using System.ComponentModel.DataAnnotations;

namespace GestaoEstacionamentoRotativo.Models{

    public class Veiculo{

        public int Id { get; set; }

        [Required]
        public string? Placa { get; set; }
        
        [Required]
        public string? Marca { get; set; }
        
        [Required]
        public string? Nome { get; set; }

        public int CategoriaId { get; set; }
        
        [Required]
        public virtual VeiculoCategoria Categoria { get; set; }
    }
}