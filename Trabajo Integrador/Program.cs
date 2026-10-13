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
            // Metodo para crear paciente 
            void CrearPaciente()
            {
                try
                {
                    Console.WriteLine("Ingrese el Dni del Paciente: ");
                    string Dni= Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(Dni))
                    {
                        throw new ArgumentException("El Dni no puede estar vacío o en blanco.");
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
                        throw new ArgumentException("El apellido del paciente no puede estar vacío.");
                    }

                    Console.WriteLine("Ingrese el numero de telefono del paciente");
                    string telefono = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(telefono))
                    {
                        throw new ArgumentException("El número de teléfono no puede estar vacío.");
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
                    Espacio espacio = new Espacio(numero, nroPiso, ala, medico);
                    ClinicaDeLuis.AgregarEspacio(espacio);
                    Console.WriteLine("Espacio agregado con exito");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n[ATENCIÓN]: {ex.Message}\n");
                }
            }

            // menu principal

            CrearMedico();
            CrearPaciente();
            CrearEspacio();
        }
    }
}
