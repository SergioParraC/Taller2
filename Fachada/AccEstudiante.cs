using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fundacionales;
using Modelo;

namespace Fachada
{
    public class AccEstudiante
    {
        private AccionesEstudiante accionesEstudiante = new AccionesEstudiante();
        public void AgregarEstudiante(Estudiantes estudiante)
        {
            accionesEstudiante.AgregarEstudiante(estudiante);
        }
        public List<Estudiantes> ObtenerEstudiantes()
        {
            return accionesEstudiante.ObtenerEstudiantes();
        }
        public List<Estudiantes> ObtenerEstudiantesNotasSup(double nota)
        {
            return accionesEstudiante.ObtenerEstudiantesNotasSup(nota);
        }
        public List<Estudiantes> OrdenarEstudiantesPorNota()
        {
            return accionesEstudiante.OrdenarEstudiantesPorNota();
        }
        public List<Estudiantes> ObtenerEstudiantesOrdenadosPorId()
        {
            return accionesEstudiante.ObtenerEstudiantesOrdenadosPorId();
        }
    }
}
