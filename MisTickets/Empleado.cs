namespace MisTickets;

public class Empleado : Persona
{
    public string Departamento { get; set; }

    public Empleado(string nombres, string apellidos, string departamento) : base(nombres, apellidos)
    {
        if (string.IsNullOrWhiteSpace(departamento))
            Departamento = "Sin departamento";
        else
            Departamento = departamento;
    }
}
