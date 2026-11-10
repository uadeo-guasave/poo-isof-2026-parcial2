using MisTickets;
using Spectre.Console;

Console.WriteLine("Hola, Mundo!");

// var persona1 = new Persona();
// ERROR: no se pueden crear instancias de una clase abstracta

var empleado1 = new Empleado { Nombres = "Manuel", Apellidos = "Pon Atención", Departamento = "Ignoro La Clase" };

var secreSoporte = new PersonalDeSoporte { Nombres = "Judith", Apellidos = "X", Puesto = "Secretaria", TareasPrincipales = "Registrar solicitudes de apoyo en soporte técnico" };

var formateador = new PersonalDeSoporte { Nombres = "El", Apellidos = "Que Te Atendió a Martín", Puesto = "Experto en formatear", TareasPrincipales = "Perder información del usuario y formatear para remediar" };

AnsiConsole.Write(new FigletText("Hola, Mundo!").Color(Color.DarkRed));

// Paso 2 - Pruebas
var mesa = new MesaDeAyuda();

var ticket1 = new Ticket
{
    Registró = secreSoporte,
    Solicitante = empleado1,
    Descripción = "Ayuda, instalé fortnite pirata y se reinició mi compu y ya no entra a windows"
};

mesa.Registrar(ticket1);
AnsiConsole.Write(mesa.ObtenerTodos().Count);
