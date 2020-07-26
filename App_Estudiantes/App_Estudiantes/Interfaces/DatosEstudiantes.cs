using App_Estudiantes.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Estudiantes.Interfaces
{
    interface DatosEstudiantes
    {
        List<Estudiante> getAllEstudiantes();
        double valorMatricula();
    }
}
