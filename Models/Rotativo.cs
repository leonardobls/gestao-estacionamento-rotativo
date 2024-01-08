using System.ComponentModel.DataAnnotations;

namespace GestaoEstacionamentoRotativo.Models{

    public class Rotativo{

        public int Id { get; set; }

        [Required]
        public DateTime Chegada { get; set; }

        public int VeiculoId { get; set; }

        public virtual Veiculo? Veiculo { get; set; }
    }
}