using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Estudiantes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double[] Calificaciones { get; set; }
        public double Promedio => Calificaciones.Length > 0 ? Calificaciones.Average() : 0;
        public Estudiantes(int id,string nombre, double[] calificaciones)
        {
            Id = id;
            Nombre = nombre;
            Calificaciones = calificaciones;
        }

    }
}
