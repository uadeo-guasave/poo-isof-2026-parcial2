using MisTickets;

// var persona1 = new Persona();
// ERROR: no se pueden crear instancias de una clase abstracta

var empleado1 = new Empleado { Nombres = "Manuel", Apellidos = "Pon Atención", Departamento = "Ignoro La Clase" };

var secreSoporte = new PersonalDeSoporte { Nombres = "Judith", Apellidos = "X", Puesto = "Secretaria", TareasPrincipales = "Registrar solicitudes de apoyo en soporte técnico" };

var formateador = new PersonalDeSoporte { Nombres = "El", Apellidos = "Que Te Atendió a Martín", Puesto = "Experto en formatear", TareasPrincipales = "Perder información del usuario y formatear para remediar" };

var empleado2 = new Empleado { Nombres = "Ana", Apellidos = "López", Departamento = "Contabilidad" };

var mesa = new MesaDeAyuda();
mesa.Registrar(new Ticket { Solicitante = empleado1, Descripción = "La impresora no imprime", Registró = secreSoporte });
mesa.Registrar(new Ticket { Solicitante = empleado2, Descripción = "No enciende la computadora", Registró = secreSoporte });
mesa.Registrar(new Ticket { Solicitante = empleado1, Descripción = "Olvidé mi contraseña [urgente]", Registró = secreSoporte });

mesa.Cerrar(2, formateador, "Se formateó el equipo");

var vista = new VistaDeTickets();
vista.MostrarEncabezado();
vista.MostrarTabla("Todos los tickets", mesa.ObtenerTodos());
vista.MostrarTabla("Tickets pendientes", mesa.ObtenerPendientes());