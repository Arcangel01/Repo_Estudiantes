using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Estudiantes.Clases
{
    class Estudiante
    {
        private int cedula_identidad;
        private string nombres;
        private string apellidos;
        private string nombre_institucion;

        public int getCedula()
        {
            return this.cedula_identidad;
        }

        public void setCedula(int cedula_identidad)
        {
            this.cedula_identidad = cedula_identidad;
        }

        public string getNombres()
        {
            return nombres;
        }

        public void setNombres(string nombres)
        {
            this.nombres = nombres;
        }

        public string getApellidos()
        {
            return apellidos;
        }

        public void setApellidos(string apellidos)
        {
            this.apellidos = apellidos;
        }

        public string getInstitucion()
        {
            return nombre_institucion;
        }

        public void setInstitucion(string institucion)
        {
            this.nombre_institucion = institucion;
        }

        public void verEstudiantes()
        {
            Console.WriteLine("Numero de identificación: " + this.cedula_identidad);
            Console.WriteLine("Nombres: " + this.nombres);
            Console.WriteLine("Apellidos: " + this.apellidos);
            Console.WriteLine("Nombre de la institución: " + this.nombre_institucion);
        }
    }
}
