namespace gestao_estacionamento_rotativo.Models;

public class Ticket{

    public int id_ticket { get; set; }

    public int id_vaga { get; set; }

    public DateOnly date { get; set; }

    public DateTime data_ini { get; set; }

    public DateTime data_final { get; set; }

    public float preco { get; set; }

    public bool pago { get; set; }
}