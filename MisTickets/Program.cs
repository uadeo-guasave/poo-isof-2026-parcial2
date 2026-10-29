using MisTickets;

Console.WriteLine("Hola, Mundo!");

// var persona1 = new Persona();
// ERROR: no se pueden crear instancias de una clase abstracta

var empleado1 = new Empleado { Nombres = "Manuel", Apellidos = "Pon Atención", Departamento = "Ignoro La Clase" };

var secreSoporte = new PersonalDeSoporte { Nombres = "Judith", Apellidos = "X", Puesto = "Secretaria", TareasPrincipales = "Registrar solicitudes de apoyo en soporte técnico" };

var formateador = new PersonalDeSoporte { Nombres = "El", Apellidos = "Que Te Atendió a Martín", Puesto = "Experto en formatear", TareasPrincipales = "Perder información del usuario y formatear para remediar" };
