using App_Estudiantes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Estudiantes.Clases
{
    class EstudianteUniversitario : DatosEstudiantes
    {
        private List<Estudiante> estudiantes;
        public int cantidad_creditos;
        private double precio_credito = 7;
        private double valor;

        public EstudianteUniversitario(int cantidad_creditos)
        {
            this.estudiantes = new List<Estudiante>();
            Estudiante estudiante = new Estudiante();
            this.cantidad_creditos = cantidad_creditos;
            estudiante.setCedula(109388472);
            estudiante.setNombres("Jorge Luis");
            estudiante.setApellidos("Londoño Villa");
            estudiante.setInstitucion("ULEAM - Universidad Laica");
            estudiantes.Add(estudiante);
        }

        public double valorMatricula()
        {
            try
            {
                valor = cantidad_creditos * precio_credito;
            } catch(Exception ex)
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
