using System;
//PROGRAMA ELABORADO POR EMILY GUTIERREZ.
namespace SistemaControl
{
    class Program
    {
        public static void Main(string[] args)
        {
            Universidad universidad = new Universidad();

            universidad.RegistrarEstudiante(new Universidad.Estudiante("Roberto", "Gomez", 40, 28));
            universidad.RegistrarEstudiante(new Universidad.Estudiante("Merlin", "D'Trinidad", 40, 37));
            universidad.RegistrarEstudiante(new Universidad.Estudiante("Tony", "MiraFlores", 40, 18));
            universidad.RegistrarEstudiante(new Universidad.Estudiante("Yuliza", "Castro", 40, 40));
            universidad.RegistrarEstudiante(new Universidad.Estudiante("Cristopher", "Gutierrez", 40, 5));
            universidad.RegistrarEstudiante(new Universidad.Estudiante("Ericka", "Martinez", 40, 32));
            universidad.RegistrarEstudiante(new Universidad.Estudiante("Humberto", "RodriDguez", 40, 25));
            universidad.RegistrarEstudiante(new Universidad.Estudiante("Jean", "Leon", 40, 11));
            universidad.RegistrarEstudiante(new Universidad.Estudiante("Dafnne", "Jimenez", 40, 29));


            foreach (Universidad.Estudiante estudiante in universidad.Estudiantes) 
            {
                estudiante.MostrarInformacion();
                Console.WriteLine();
            }
        }
    }
}
