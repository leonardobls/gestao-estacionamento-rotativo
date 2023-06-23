namespace gestao_estacionamento_rotativo.Models;

public class Veiculo{

    public int id_veiculo { get; set; }

    public int id_mensalista { get; set; }

    public Boolean mensalista { get; set; }

    public string? placa { get; set; }

    public string? marca { get; set; }

    public string? modelo { get; set; }

    public string? cor { get; set; }
}