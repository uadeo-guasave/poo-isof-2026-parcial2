namespace MisTickets;

public class PersonalDeSoporte : Persona
{
    public string Puesto { get; set; }
    public string TareasPrincipales { get; set; }

    public PersonalDeSoporte(string nombres, string apellidos, string puesto, string tareasPrincipales) : base(nombres, apellidos)
    {
        Puesto = puesto;
        TareasPrincipales = tareasPrincipales;
    }
}
