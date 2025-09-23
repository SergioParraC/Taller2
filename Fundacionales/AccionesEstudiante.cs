using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Fundacionales
{
    public class AccionesEstudiante
    {
        private List<Estudiantes> listaEstudiantes = new List<Estudiantes>();
        public void AgregarEstudiante(Estudiantes estudiante)
        {
            listaEstudiantes.Add(estudiante);
        }
        public List<Estudiantes> ObtenerEstudiantes()
        {
            return listaEstudiantes;
        }
        public List<Estudiantes> ObtenerEstudiantesOrdenadosPorId()
        {
            return listaEstudiantes.OrderBy(e => e.Id).ToList();
        }
        public List<Estudiantes> ObtenerEstudiantesNotasSup(double nota)
        {
            List<Estudiantes> estudiantesAprobados = new List<Estudiantes>();
            foreach (var estudiante in listaEstudiantes)
            {
                if (estudiante.Promedio > nota)
                {
                    Console.WriteLine($"Id: {estudiante.Id}, Nombre: {estudiante.Nombre}, Nota: {estudiante.Promedio}");
                    estudiantesAprobados.Add(estudiante);
                }
            }
            return estudiantesAprobados;
        }
        public List<Estudiantes> OrdenarEstudiantesPorNota()
        {
            return listaEstudiantes.OrderByDescending(e => e.Promedio).ToList();
        }
    }
}
