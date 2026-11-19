namespace MisTickets;

public class Empleado : Persona
{
    public string Departamento { get; set; }

    public Empleado(string nombres, string apellidos, string departamento) : base(nombres, apellidos)
    {
        Departamento = departamento;
    }
}
