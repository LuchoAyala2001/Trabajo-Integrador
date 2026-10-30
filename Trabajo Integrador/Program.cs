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
                        throw new InvalidOperationException("Ya existe un Paciente registrado con ese Dni.");
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
                        throw new FormatException("El Consultorio debe ser un número entero.");
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
                    Console.WriteLine("Ingrese el ala del consultorio: 1-Norte, 2-Sur, 3-Este, 4-Oeste");
                    string ala = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(ala))
                    {
                        throw new ArgumentException("El ala del consultorio no puede estar vacía.");
                    }
                    if (ala != "1" && ala != "2" && ala != "3" && ala != "4")
                    {
                        throw new ArgumentException("El ala del consultorio debe ser '1', '2', '3' o '4'.");
                    }
                    if (ala == "1") ala = "Norte";
                    else if (ala == "2") ala = "Sur";
                    else if (ala == "3") ala = "Este";
                    else if (ala == "4") ala = "Oeste"; 

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
                    Console.WriteLine("Ingrese el tipo de consultorio(Asigne '1', '2' '3' '4'): ");
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
                    if (nroTipo == 1)
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
                            else if (respuesta != 'S' && respuesta != 's')
                            {
                                throw new ArgumentException("Respuesta inválida. Debe ingresar 'S' o 'N'.");
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
                        if (respuesta != '1' && respuesta != '2' && respuesta != '3')
                        {
                            throw new ArgumentException("Tipo de estudio invalido. Debe ingresar 1, 2 o 3.");
                        }
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
                            Console.WriteLine("Ingrese el nivel de urgencia (1-5): ");
                            string entradaNivel = Console.ReadLine();
                            if (!int.TryParse(entradaNivel, out int nivelUrgencia) || nivelUrgencia < 1 || nivelUrgencia > 5)
                            {
                                throw new FormatException("El nivel de urgencia debe ser un número entero entre 1 y 5.");
                            }
                            SalaUrgencia salaUrgencia = new SalaUrgencia(numero, nroPiso, ala, medico, libre, nivelUrgencia);
                            ClinicaDeLuis.AgregarEspacio(salaUrgencia);
                        }
                        else if (respuesta == 'N' || respuesta == 'n')
                        {
                            libre = false;
                            Console.WriteLine("Ingrese el Dni del Paciente: ");
                            string dni = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(dni))
                            {
                                throw new ArgumentException("El Dni del paciente no puede estar vacío.");
                            }
                            Paciente pacienteUrgencia = ClinicaDeLuis.BuscarPaciente(dni);
                            if (pacienteUrgencia == null)
                            {
                                throw new InvalidOperationException("No existe un paciente registrado con ese DNI.");
                            }
                            Console.WriteLine("Ingrese el nivel de urgencia (1-5): ");
                            string entradaNivel = Console.ReadLine();
                            if (!int.TryParse(entradaNivel, out int nivelUrgencia) || nivelUrgencia < 1 || nivelUrgencia > 5)
                            {
                                throw new FormatException("El nivel de urgencia debe ser un número entero entre 1 y 5.");
                            }
                            SalaUrgencia salaUrgencia = new SalaUrgencia(numero, nroPiso, ala, medico, libre, pacienteUrgencia, nivelUrgencia);
                            ClinicaDeLuis.AgregarEspacio(salaUrgencia);
                        }
                        else
                        {
                            throw new ArgumentException("Respuesta inválida. Debe ingresar 'S' o 'N'.");
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
                try
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
                catch (Exception ex)
                {
                    Console.WriteLine($"\n[ATENCIÓN]: {ex.Message}\n");
                }
            }
            // Buscar solo consultorios especializados
            List<ConsultorioEspecializado> MostrarCEspecializados()
            {
                List<ConsultorioEspecializado> consultorioEspecializados = new List<ConsultorioEspecializado>();
                foreach (var espacio in ClinicaDeLuis.RetornarEspacios())
                {
                    if (espacio is ConsultorioEspecializado consultorioEspecializado)
                    {
                        consultorioEspecializados.Add(consultorioEspecializado);
                    }
                }
                return consultorioEspecializados;
            }
                //Buscar consultorios especializados segun dia de la semana
                void ConsultoriosPorDia()
                {
                    try
                    {
                        Console.WriteLine("Ingrese el dia de la semana (ej: lunes): ");
                        string dia = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(dia))
                        {
                            throw new ArgumentException("El dia no puede estar vacio.");
                        }
                        if (!TryParseDia(dia, out DayOfWeek diaSemana))
                        {
                            throw new FormatException("Día inválido. Ingresá lunes, martes, miercoles, etc.");
                        }

                        bool encontrado = false;
                        foreach (var consultorio in MostrarCEspecializados())
                        {
                            foreach (var horario in consultorio.HorariosAtencion)
                            {
                                if (horario.DiaSemana == diaSemana)
                                {
                                    Console.WriteLine($"Consultorio {consultorio.NroConsultorio} abre el {horario.DiaSemana} de {horario.HoraApertura} a {horario.HoraCierre}");
                                    encontrado = true;
                                }
                            }
                        }

                        if (!encontrado)
                        {
                            Console.WriteLine("No hay consultorios especializados que abran ese dia.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\n[ATENCIÓN]: {ex.Message}\n");
                    }
                }
                // Metodo de estadisticas de la clinica
                void EstadisticasClinica()
                {
                    // Cantidad de consultorios
                    int totalConsultorios = ClinicaDeLuis.RetornarEspacios().Count;
                    // Porcentaje de consultorios de emergencia nivel 1 (Con respecto al total de consultorios de urgencias)
                    int totalUrgencias = ClinicaDeLuis.RetornarEspacios().Count(e => e is SalaUrgencia);
                    int nivel1Total = ClinicaDeLuis.RetornarEspacios().OfType<SalaUrgencia>().Count(s => s.NivelUrgencia == 1);
                    double porcentajeNivel1 = totalUrgencias > 0 ? (double)nivel1Total / totalUrgencias * 100 : 0;
                //Cantidad de medicos 
                int totalMedicos = ClinicaDeLuis.RetornarMedicos().Count;
                    //Cantidad de pacientes
                    int totalPacientes = ClinicaDeLuis.RetornarPacientes().Count;
                    //promedio de pacientes que realizaron recetas en consultorios generales (Con respecto al total de pacientes atendidos en consultorios generales)
                    int totalConsultoriosGenerales = ClinicaDeLuis.RetornarEspacios().Count(e => e is ConsultorioGeneral);
                    int totalPacientesConReceta = ClinicaDeLuis.RetornarEspacios().OfType<ConsultorioGeneral>().Count(c => c.Receta);
                    double promedioPacientesConReceta = totalConsultoriosGenerales > 0 ? (double)totalPacientesConReceta / totalConsultoriosGenerales * 100 : 0;
                    // Porcentaje de ecografias realizadas en salas de diagnostico (Con respecto al total de salas de diagnostico)
                    int totalSalasDiagnostico = ClinicaDeLuis.RetornarEspacios().Count(e => e is SalasDiagnostico);
                    int totalEcografias = ClinicaDeLuis.RetornarEspacios().OfType<SalasDiagnostico>().Count(s => s.TipoEstudio == "Ecografia");
                    double porcentajeEcografias = totalSalasDiagnostico > 0 ? (double)totalEcografias / totalSalasDiagnostico * 100 : 0;
                //Porcentaje de consultorios de Urgencias Libres
                int totalConsultoriosUrgenciasLibres = ClinicaDeLuis.RetornarEspacios().OfType<SalaUrgencia>().Count(s => s.Libre);
                    double porcentajeConsultoriosUrgenciasLibres = totalUrgencias > 0 ? (double)totalConsultoriosUrgenciasLibres / totalUrgencias * 100 : 0;

                    Console.WriteLine("Estadísticas de la clinica: ");
                    Console.WriteLine($"Total de consultorios: {totalConsultorios}");
                    Console.WriteLine($"Porcentaje de consultorios de emergencia nivel 1: {porcentajeNivel1:F2}%");
                    Console.WriteLine($"Total de médicos: {totalMedicos}");
                    Console.WriteLine($"Total de pacientes: {totalPacientes}");
                    Console.WriteLine($"Promedio de pacientes con receta en consultorios generales: {promedioPacientesConReceta:F2}%");
                    Console.WriteLine($"Porcentaje de ecografías realizadas en salas de diagnóstico: {porcentajeEcografias:F2}%");
                    Console.WriteLine($"Porcentaje de consultorios de urgencias libres: {porcentajeConsultoriosUrgenciasLibres:F2}%");
                }
            //Menu principal
            void MostrarMenu()
            {
                Console.WriteLine("Elija la accion a realizar: ");
                Console.WriteLine("1- Agregar Médico ");
                Console.WriteLine("2- Agregar Paciente ");
                Console.WriteLine("3- Agregar Consultorio ");
                Console.WriteLine("4- Buscar Consultorio ");
                Console.WriteLine("5- Buscar Consultorios especializados y sus horarios ");
                Console.WriteLine("6- Mostrar Estadísticas ");
                Console.WriteLine("0- Salir ");
            }

            void MenuPrincipal()
            {
                Console.WriteLine("Bienvenido!");
                int opcion = -1;

                while (opcion != 0)
                {
                    try
                    {
                        MostrarMenu();
                        if (!int.TryParse(Console.ReadLine(), out opcion))
                        {
                            opcion = -1;
                            throw new FormatException("La opción debe ser un número entero.");
                        }

                        switch (opcion)
                        {
                            case 0:
                                Console.WriteLine("Saliendo...");
                                break;
                            case 1:
                                CrearMedico();
                                break;
                            case 2:
                                CrearPaciente();
                                break;
                            case 3:
                                CrearEspacio();
                                break;
                            case 4:
                                BuscarEspacio();
                                break;
                            case 5:
                                ConsultoriosPorDia();
                                break;
                            case 6:
                                EstadisticasClinica();
                                break;
                            default:
                                throw new ArgumentException("Opción inválida. Debe ingresar un número entre 0 y 6.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\n[ATENCIÓN]: {ex.Message}\n");
                    }
                }
            }
            MenuPrincipal();
        }
    }
}