using System.Security.Cryptography.X509Certificates;

namespace Trabajo_Integrador
{
    public class Program
    {
        public static void Main()
        {
            Clinica ClinicaDeLuis = new Clinica();

            // Metodo para crear medico y agregarlo a la clinica
            void CrearMedico()
            {
                try
                {
                    Console.WriteLine("Ingrese la matricula del medico: ");
                    string entradaMatricula = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(entradaMatricula))
                    {
                        throw new ArgumentException("La matrícula no puede estar vacía o en blanco.");
                    }
                    if (!int.TryParse(entradaMatricula, out int matricula))
                    {
                        throw new FormatException("La matrícula debe ser un número entero.");
                    }
                    if (ClinicaDeLuis.buscarmedico(matricula) != null)
                    {
                        throw new InvalidOperationException("Ya existe un médico registrado con esa misma matrícula.");
                    }

                    Console.WriteLine("Ingrese el nombre del medico: ");
                    string nombre = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nombre))
                    {
                        throw new ArgumentException("El nombre del médico no puede estar vacío.");
                    }

                    Console.WriteLine("Ingrese el apellido del medico: ");
                    string apellido = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(apellido))
                    {
                        throw new ArgumentException("El apellido del médico no puede estar vacío.");
                    }

                    Console.WriteLine("Ingrese la especialidad del medico: ");
                    string especialidad = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(especialidad))
                    {
                        throw new ArgumentException("La especialidad no puede estar vacía.");
                    }
                    Medico medico = new Medico(matricula, nombre, apellido, especialidad);
                    ClinicaDeLuis.AgregarMedico(medico);
                    Console.WriteLine("¡Médico agregado con éxito!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n[ATENCIÓN]: {ex.Message}\n");
                }
            }
            // Metodo para crear paciente y sus excepciones
            void CrearPaciente()
            {
                try
                {
                    Console.WriteLine("Ingrese el Dni del Paciente: ");
                    string Dni = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(Dni))
                    {
                        throw new ArgumentException("El Dni no puede estar vacio o en blanco.");
                    }

                    if (ClinicaDeLuis.BuscarPaciente(Dni) != null)
                    {
                        throw new InvalidOperationException("Ya existe un Paciente registrado con esa misma matrícula.");
                    }

                    Console.WriteLine("Ingrese el nombre del paciente: ");
                    string nombre = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(nombre))
                    {
                        throw new ArgumentException("El nombre del paciente no puede estar vacío.");
                    }

                    Console.WriteLine("Ingrese el apellido del paciente: ");
                    string apellido = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(apellido))
                    {
                        throw new ArgumentException("El apellido del paciente no puede estar vacio.");
                    }

                    Console.WriteLine("Ingrese el numero de telefono del paciente");
                    string telefono = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(telefono))
                    {
                        throw new ArgumentException("El numero de telefono no puede estar vacio.");
                    }
                    Paciente paciente = new Paciente(Dni, nombre, apellido, telefono);
                    ClinicaDeLuis.AgregarPaciente(paciente);
                    Console.WriteLine("¡Paciente agregado con éxito!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n[ATENCIÓN]: {ex.Message}\n");
                }
            }
            // Metodo Agregar Espacio y sus excepciones
            void CrearEspacio()
            {
                try
                {
                    Console.WriteLine("Ingrese el numero del Consultorio: ");
                    string entradaNumero = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(entradaNumero))
                    {
                        throw new ArgumentException("El numero del consultorio no puede estar vacio.");
                    }
                    if (!int.TryParse(entradaNumero, out int numero))
                    {
                        throw new FormatException("La matrícula debe ser un número entero.");
                    }

                    if (ClinicaDeLuis.BuscarConsultorio(numero) != null)
                    {
                        throw new InvalidOperationException("Ya existe un consultorio registrado con ese mismo número.");
                    }
                    Console.WriteLine("Ingrese el numero de piso: ");
                    string piso = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(piso))
                    {
                        throw new ArgumentException("El número de piso no puede estar vacío.");
                    }
                    if (!int.TryParse(piso, out int nroPiso))
                    {
                        throw new FormatException("El número de piso debe ser un número entero.");
                    }
                    Console.WriteLine("Ingrese el ala del consultorio: ");
                    string ala = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(ala))
                    {
                        throw new ArgumentException("El ala del consultorio no puede estar vacía.");
                    }

                    Console.WriteLine("Ingrese la matricula del medico");
                    string matricula = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(matricula))
                    {
                        throw new ArgumentException("La matrícula del médico no puede estar vacía.");
                    }
                    if (!int.TryParse(matricula, out int nroMatricula))
                    {
                        throw new FormatException("La matrícula debe ser un numero entero.");
                    }
                    Medico medico = ClinicaDeLuis.buscarmedico(nroMatricula);
                    if (medico == null)
                    {
                        throw new InvalidOperationException("No existe un medico registrado con esa matricula.");
                    }
                    Console.WriteLine("Ingrese el tipo de consultorio(Asigne '1', '2' o '3'):");
                    Console.WriteLine("1- Consultorio General");
                    Console.WriteLine("2- Consultorio Especializado");
                    Console.WriteLine("3- Sala de Diagnóstico");
                    Console.WriteLine("4- Sala de Urgencia");
                    string tipo = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(tipo))
                    {
                        throw new ArgumentException("El tipo de consultorio no puede estar vacío.");
                    }
                    if (!int.TryParse(tipo, out int nroTipo))
                    {
                        throw new FormatException("El tipo de consultorio debe ser un número entero.");
                    }
                    if (tipo == "1")
                    {
                        Console.WriteLine("¿Se genero una receta?/S/N");
                        char respuesta = Console.ReadKey().KeyChar;
                        bool receta = true;
                        if (respuesta == 'S' || respuesta == 's')
                        {
                            receta = true;
                        }
                        else if (respuesta == 'N' || respuesta == 'n')
                        {
                            receta = false;
                        }
                        else
                        {
                            throw new ArgumentException("Respuesta inválida. Debe ingresar 'S' o 'N'.");
                        }
                        ConsultorioGeneral cGeneral = new ConsultorioGeneral(numero, nroPiso, ala, medico, receta);
                        ClinicaDeLuis.AgregarEspacio(cGeneral);
                        Console.WriteLine("Espacio agregado con exito");
                    }
                    else if (nroTipo == 2)
                    {
                        Console.WriteLine("Ingrese la especialidad del consultorio: ");
                        string especialidad = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(especialidad))
                        {
                            throw new ArgumentException("La especialidad del consultorio no puede estar vacía.");
                        }
                        bool horario = true;
                        List<HorarioAtencion> horarioConsultorio = new List<HorarioAtencion>();
                        while (horario == true)
                        {
                            Console.Write("Ingrese Hora de apertura (HH:mm): ");
                            if (!TimeOnly.TryParse(Console.ReadLine(), out TimeOnly apertura))
                                throw new FormatException("Hora de apertura inválida.");

                            Console.Write("Ingrese Hora de cierre (HH:mm): ");
                            if (!TimeOnly.TryParse(Console.ReadLine(), out TimeOnly cierre))
                                throw new FormatException("Hora de cierre inválida.");

                            if (cierre <= apertura)
                                throw new ArgumentException("El cierre debe ser posterior a la apertura.");

                            Console.Write("Día de la semana (ej: Lunes): ");
                            if (!TryParseDia(Console.ReadLine(), out DayOfWeek dia))
                                throw new FormatException("Día inválido. Ingresá lunes, martes, miércoles, etc.");
                            HorarioAtencion horarioConsultoriodia = new HorarioAtencion(apertura, cierre, dia);
                            horarioConsultorio.Add(horarioConsultoriodia);
                            Console.WriteLine("¿Desea agregar otro horario? (S/N): ");
                            char respuesta = Console.ReadKey().KeyChar;
                            if (respuesta == 'N' || respuesta == 'n')
                            {
                                horario = false;
                            }
                        }
                        ConsultorioEspecializado cEspecializado = new ConsultorioEspecializado(numero, nroPiso, ala, medico, especialidad, horarioConsultorio);
                        ClinicaDeLuis.AgregarEspacio(cEspecializado);
                        Console.WriteLine("Espacio agregado con exito");
                    }
                    else if (nroTipo == 3)
                    {
                        Console.Write("Ingrese el tipo de estudio: 1_ Radiografia, 2_ Ecografia, 3_ Tomografia: ");
                        char respuesta = Console.ReadKey().KeyChar;
                        string tipoEstudio = "";
                        switch (respuesta)
                        {
                            case '1':
                                tipoEstudio = "Radiografia";
                                break;
                            case '2':
                                tipoEstudio = "Ecografia";
                                break;
                            case '3':
                                tipoEstudio = "Tomografia";
                                break;
                            default:
                                throw new FormatException("Tipo de estudio inválido.");
                        }
                        SalasDiagnostico sDiagnostico = new SalasDiagnostico(numero, nroPiso, ala, medico, tipoEstudio);
                        ClinicaDeLuis.AgregarEspacio(sDiagnostico);
                        Console.WriteLine("Espacio agregado con exito");
                    }
                    else if (nroTipo == 4)
                    {
                        Console.WriteLine("¿El consultorio esta libre? (S/N)");
                        char respuesta = Console.ReadKey().KeyChar;
                        bool libre = true;
                        if (respuesta == 'S' || respuesta == 's')
                        {
                            libre = true;
                            SalaUrgencia salaUrgencia = new SalaUrgencia(numero, nroPiso, ala, medico, libre);
                        }
                        else if (respuesta == 'N' || respuesta == 'n')
                        {
                            libre = false;
                            Console.WriteLine("Ingrese el Dni del Paciente: ");
                            string dni = Console.ReadLine();
                            Paciente pacienteUrgencia = ClinicaDeLuis.BuscarPaciente(dni);
                            SalaUrgencia salaUrgencia = new SalaUrgencia(numero, nroPiso, ala, medico, libre, pacienteUrgencia);
                            ClinicaDeLuis.AgregarEspacio(salaUrgencia);
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Tipo de consultorio inválido. Debe ingresar 1, 2, 3 o 4.");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n[ATENCIÓN]: {ex.Message}\n");
                }
            }

            // Convierte "lunes", "Miercoles", etc. en DayOfWeek
            static bool TryParseDia(string? texto, out DayOfWeek dia)
            {
                dia = default;

                if (string.IsNullOrWhiteSpace(texto))
                    return false;

                switch (texto.ToLower())
                {
                    case "lunes": dia = DayOfWeek.Monday; return true;
                    case "martes": dia = DayOfWeek.Tuesday; return true;
                    case "miercoles":
                    case "miércoles": dia = DayOfWeek.Wednesday; return true;
                    case "jueves": dia = DayOfWeek.Thursday; return true;
                    case "viernes": dia = DayOfWeek.Friday; return true;
                    case "sabado":
                    case "sábado": dia = DayOfWeek.Saturday; return true;
                    case "domingo": dia = DayOfWeek.Sunday; return true;
                    default: return false;
                }
            }
            // Buscar Espacio
            void BuscarEspacio()
            {
                Console.WriteLine("Ingrese el numero del consultorio a buscar: ");
                string entradaNumero = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(entradaNumero))
                {
                    throw new ArgumentException("El numero del consultorio no puede estar vacio.");
                }
                if (!int.TryParse(entradaNumero, out int numero))
                {
                    throw new FormatException("El numero del consultorio debe ser un numero entero.");
                }
                Espacio espacio = ClinicaDeLuis.BuscarConsultorio(numero);
                if (espacio == null)
                {
                    Console.WriteLine("No se encontro el consultorio");
                }
                else
                {
                    espacio.imprimirEspacio();
                }
            }
            // Buscar solo consultorios especializados
            List<ConsultorioEspecializado> mostrarCEspecializados()
            {
                List<ConsultorioEspecializado> consultorioEspecializados = new List<ConsultorioEspecializado>();
                foreach (var espacio in ClinicaDeLuis.RetornarEspacios())
                {
                    if (espacio is ConsultorioEspecializado consultorioEspecializado)
                    {
                        consultorioEspecializados.Add(consultorioEspecializado);
                    }
                }
                foreach (var consultorio in consultorioEspecializados)
                {
                    consultorio.imprimirEspacio();
                }
                return consultorioEspecializados;
            }
            //Buscar consultorios especializados segun dia de la semana
            void consultoriosPorDia(string dia)
            {
                if (string.IsNullOrWhiteSpace(dia))
                {
                    throw new ArgumentException("El dia no puede estar vacío.");
                }
                if (!TryParseDia(dia, out DayOfWeek diaSemana))
                {
                    throw new FormatException("Día inválido. Ingresá lunes, martes, miercoles, etc.");
                }

                List<ConsultorioEspecializado> consultorios = mostrarCEspecializados();
                foreach (var consultorio in consultorios)
                {
                    foreach (var horario in consultorio.HorariosAtencion)
                    {
                        if (horario.DiaSemana == diaSemana || horario.DiaSemana != DayOfWeek.Saturday || horario.DiaSemana != DayOfWeek.Sunday)
                        {
                            consultorio.imprimirEspacio();
                        }
                        else
                        {
                            Console.WriteLine($"El consultorio {consultorio.NroConsultorio} no abre los fines de semana");
                        }
                    }
                }

                // menu principal

                CrearMedico();
                CrearEspacio();
                CrearEspacio();

                foreach (var espacio in ClinicaDeLuis.RetornarEspacios())
                {
                    espacio.imprimirEspacio();

                }
            }
        }
    }
}
