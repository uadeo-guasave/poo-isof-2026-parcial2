namespace MisTickets;

public abstract class Persona
{
    public string Nombres { get; set; }
    public string Apellidos { get; set; }

    public string NombreCompleto()
    {
        return $"{Nombres} {Apellidos}";
    }
}
