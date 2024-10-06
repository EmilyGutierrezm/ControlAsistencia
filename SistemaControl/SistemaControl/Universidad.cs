using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaControl
{
    public class Universidad
    {
        public List<Estudiante> Estudiantes { get; set; }

        public Universidad()
        {
            Estudiantes = new List<Estudiante>();
        }

        public void RegistrarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
        }

        public class Estudiante
        {
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int NumeroSesionesTotales { get; set; }
            public int NumeroSesionesAsistidas { get; set; }
            public Asistencia Asistencia { get; set; }

            public Estudiante(string nombre, string apellido, int numeroSesionesTotales, int numeroSesionesAsistidas)
            {
                Nombre = nombre;
                Apellido = apellido;
                NumeroSesionesTotales = numeroSesionesTotales;
                NumeroSesionesAsistidas = numeroSesionesAsistidas;
                Asistencia = new Asistencia(this);
            }
        }

        public class Asistencia
        {
            private Estudiante estudiante;

            public Asistencia(Estudiante estudiante)
            {
                this.estudiante = estudiante;
            }

            public static double CalcularPorcentajeAsistencia(Estudiante estudiante)
            {
                return (double)estudiante.NumeroSesionesAsistidas / estudiante.NumeroSesionesTotales * 100;
            }

            public static bool CumpleMinimoAsistencia(Estudiante estudiante)
            {
                return CalcularPorcentajeAsistencia(estudiante) >= 75;
            }
        }
    }

    public static class EstudianteExtensions
    {
        public static void MostrarInformacion(this Universidad.Estudiante estudiante) 
        {
            double porcentajeAsistencia = Universidad.Asistencia.CalcularPorcentajeAsistencia(estudiante);
            bool cumpleMinimo = Universidad.Asistencia.CumpleMinimoAsistencia(estudiante);

            Console.WriteLine($"Nombre: {estudiante.Nombre}");
            Console.WriteLine($"Apellido: {estudiante.Apellido}");
            Console.WriteLine($"Porcentaje de asistencia: {porcentajeAsistencia:F2}%");
            Console.WriteLine($"Cumple con el mínimo de asistencia: {(cumpleMinimo ? "Sí" : "No")}");
        }
    }
}

