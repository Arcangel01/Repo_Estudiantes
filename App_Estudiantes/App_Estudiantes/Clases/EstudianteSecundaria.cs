using App_Estudiantes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Estudiantes.Clases
{
    class EstudianteSecundaria : DatosEstudiantes
    {
        private List<Estudiante> estudiantes;
        private int nivel_cursado;
        private double precio_fijo_nivel = 20;
        private double valor;

        public EstudianteSecundaria(int nivel_cursado)
        {
            this.estudiantes = new List<Estudiante>();
            Estudiante estudiante = new Estudiante();
            this.nivel_cursado = nivel_cursado;
            estudiante.setCedula(1307382);
            estudiante.setNombres("Juan Luis");
            estudiante.setApellidos("Guerra Morales");
            estudiante.setInstitucion("Intitución Tricentenario de Bello");
            estudiantes.Add(estudiante);
        }

        public double valorMatricula()
        {
            try
            {
                valor = nivel_cursado * precio_fijo_nivel;
            }
            catch(Exception ex)
            {

            }
            return valor;
        }

        public List<Estudiante> getAllEstudiantes()
        {
            return this.estudiantes;
        }
    }
}
