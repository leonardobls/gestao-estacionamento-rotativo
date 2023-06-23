namespace gestao_estacionamento_rotativo.Models;

public class Vaga{

    public int id_vaga { get; set; }

    public int id_veiculo { get; set; }

    public string? intdescricao { get; set; }

    public bool ocupada { get; set; }
}