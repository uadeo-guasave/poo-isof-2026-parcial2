using MisTickets;

// var persona1 = new Persona();
// ERROR: no se pueden crear instancias de una clase abstracta

// var empleado1 = new Empleado { Nombres = "Manuel", Apellidos = "Pon Atención", Departamento = "Ignoro La Clase" };
var empleado1 = new Empleado("Manuel", "Pon Atención", "Ignoro La Clase");

var secreSoporte = new PersonalDeSoporte("Judith", "X", "Secretaria", "Registrar solicitudes de apoyo en soporte técnico");

var formateador = new PersonalDeSoporte("El", "Que Te Atendió a Martín", "Experto en formatear", "Perder información del usuario y formatear para remediar");

var empleado2 = new Empleado("Ana", "López", "Contabilidad");

var mesa = new MesaDeAyuda();
mesa.Registrar(new Ticket { Solicitante = empleado1, Descripción = "La impresora no imprime", Registró = secreSoporte });
mesa.Registrar(new Ticket { Solicitante = empleado2, Descripción = "No enciende la computadora", Registró = secreSoporte });
mesa.Registrar(new Ticket { Solicitante = empleado1, Descripción = "Olvidé mi contraseña [urgente]", Registró = secreSoporte });

mesa.Cerrar(2, formateador, "Se formateó el equipo");

var vista = new VistaDeTickets();
vista.MostrarEncabezado();
vista.MostrarTabla("Todos los tickets", mesa.ObtenerTodos());
vista.MostrarTabla("Tickets pendientes", mesa.ObtenerPendientes());

var empleado3 = new Empleado("Pedro", "Gómez", "");
Console.WriteLine(empleado3.Departamento); // Sin departamento
