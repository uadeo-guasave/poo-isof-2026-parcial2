namespace MisTickets;

public class MesaDeAyuda
{
    private List<Ticket> tickets { get; set; } = new();
    private int siguienteId { get; set; } = 1;

    public void Registrar(Ticket ticket)
    {
        ticket.Id = siguienteId;
        ticket.FechaDeSolicitud = DateTime.Now;
        tickets.Add(ticket);
        siguienteId++;
    
    public void Cerrar(int id, PersonalDeSoporte atendio, string resultado)
    {
        var ticket = tickets.Find(t => t.Id == id);
        if (ticket is not null)
        {
            if (!ticket.EstaCerrado)
            {
                ticket.Atendió = atendio;
                ticket.Resultado = resultado;
                ticket.SeResolvió = true;
                ticket.EstaCerrado = true;
            }
        }
    }

    public List<Ticket> ObtenerTodos()
    {
        // TODO: aqui nos quedamos
    }
}
