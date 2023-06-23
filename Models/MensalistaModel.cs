namespace gestao_estacionamento_rotativo.Models;

    public class MensalistaModel
    {
        public int id_mensalista { get; set; }

        public string? nome { get; set; }
    
        public int cpf { get; set; }

        public string? telefone { get; set; }

        public bool em_dia { get; set; }
    }
