using App_Estudiantes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Estudiantes.Clases
{
    class EstudiantePrimaria : DatosEstudiantes
    {
        private List<Estudiante> estudiantes;
        private double valor_fijo_anual = 100;

        public EstudiantePrimaria()
        {
            this.estudiantes = new List<Estudiante>();
            Estudiante estudiante = new Estudiante();

            estudiante.setCedula(283728);
            estudiante.setNombres("Jaime Luis");
            estudiante.setApellidos("Lopez Gutierrez");
            estudiante.setInstitucion("Intitución Lopez de Mesa");
            estudiantes.Add(estudiante);
        }

        public double valorMatricula()
        {
            return valor_fijo_anual;
        }

        public List<Estudiante> getAllEstudiantes()
        {
            return this.estudiantes;
        }
    }
}
