using App_Estudiantes.Clases;
using App_Estudiantes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Estudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            DatosEstudiantes datosPrimaria = new EstudiantePrimaria();
            DatosEstudiantes datosSecundaria = new EstudianteSecundaria(7);
            DatosEstudiantes datosUniversitario = new EstudianteUniversitario(7);

            Console.WriteLine("----- Mostramos todas los estudiantes -----");
            Console.WriteLine();

            estudiantes = datosPrimaria.getAllEstudiantes();
            foreach (Estudiante estudiante in estudiantes)
            {
                Console.WriteLine("--------- Estudiantes Primaria --------- ");
                estudiante.verEstudiantes();
                double valor = datosPrimaria.valorMatricula();
                Console.WriteLine("Valor de la matricula: $" + valor);
            }

            estudiantes = datosSecundaria.getAllEstudiantes();
            foreach (Estudiante estudiante in estudiantes)
            {
                Console.WriteLine("--------- Estudiantes Secundaria --------- ");
                estudiante.verEstudiantes();
                double valor = datosSecundaria.valorMatricula();
                Console.WriteLine("Valor de la matricula: $" + valor);
            }

            estudiantes = datosUniversitario.getAllEstudiantes();
            foreach (Estudiante estudiante in estudiantes)
            {
                Console.WriteLine("--------- Estudiantes Universitario --------- ");
                estudiante.verEstudiantes();
                double valor = datosUniversitario.valorMatricula();
                Console.WriteLine("Valor de la matricula: $" + valor);
            }

            Console.ReadKey();
        }
    }
}
