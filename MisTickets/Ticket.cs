namespace MisTickets;

public class Ticket
{
    public int Id { get; set; }
    public DateTime FechaDeSolicitud { get; set; }
    public Empleado Solicitante { get; set; }
    public string Descripción { get; set; }
    public PersonalDeSoporte Registró { get; set; }
    public PersonalDeSoporte Atendió { get; set; }
    public bool SeResolvió { get; set; }
    public string Resultado { get; set; }
    public bool EstaCerrado { get; set; } = false;
}
