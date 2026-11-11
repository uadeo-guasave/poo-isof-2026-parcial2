using Spectre.Console;

namespace MisTickets;

public class VistaDeTickets
{
    public void MostrarEncabezado()
    {
        AnsiConsole.Write(new FigletText("MisTickets").Color(Color.Blue));
    }

    public void MostrarTabla(string titulo, List<Ticket> tickets)
    {
        var tabla = new Table();
        tabla.Title(titulo);
        tabla.Border(TableBorder.Rounded);
        tabla.AddColumn("Id");
        tabla.AddColumn("Fecha");
        tabla.AddColumn("Solicitante");
        tabla.AddColumn("Descripción");
        tabla.AddColumn("Atendió");
        tabla.AddColumn("Estado");
        foreach (var ticket in tickets)
        {
            string atendio = ticket.Atendió == null ? "-" : ticket.Atendió.NombreCompleto();
            string estado = ticket.EstaCerrado ? "[green]Cerrado[/]" : "[yellow]Abierto[/]";
            tabla.AddRow(
            ticket.Id.ToString(),
            ticket.FechaDeSolicitud.ToString("dd/MM HH:mm"),
            Markup.Escape(ticket.Solicitante.NombreCompleto()),
            Markup.Escape(ticket.Descripción),
            Markup.Escape(atendio), estado);
        }
        AnsiConsole.Write(tabla);
    }
}
