using Fachada;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2
{
    public partial class Form1 : Form
    {
        AccEstudiante src = new AccEstudiante();
        List<Estudiantes> listEstudiante = new List<Estudiantes>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBoxId.Text);
                string nombre = textBoxNombre.Text;
                List<double> notas = new List<double>();
                notas.Add(double.Parse(textBoxNota1.Text));
                notas.Add(double.Parse(textBoxNota2.Text));
                notas.Add(double.Parse(textBoxNota3.Text));
                notas.Add(double.Parse(textBoxNota4.Text));
                notas.Add(double.Parse(textBoxNota5.Text));
                double[] todasNotas = notas.ToArray();

                Estudiantes estudiante = new Modelo.Estudiantes(id, nombre, todasNotas);

                src.AgregarEstudiante(estudiante);
                listEstudiante = src.ObtenerEstudiantes();
                dgvListado.DataSource = null;
                dgvListado.DataSource = listEstudiante;
                MessageBox.Show("Estudiante registrado exitosamente");
                textBoxId.Text = string.Empty;
                textBoxNombre.Text = string.Empty;
                textBoxNota1.Text = string.Empty;
                textBoxNota2.Text = string.Empty;
                textBoxNota3.Text = string.Empty;
                textBoxNota4.Text = string.Empty;
                textBoxNota5.Text = string.Empty;
            }
            catch
            {
                MessageBox.Show("Error al registrar el estudiante. Verifique los datos ingresados.");
            }
        }

        private void buttonMostrarID_Click(object sender, EventArgs e)
        {
            listEstudiante = src.ObtenerEstudiantesOrdenadosPorId();
            dgvListado.DataSource = null;
            dgvListado.DataSource = listEstudiante;
        }

        private void buttonProm_Click(object sender, EventArgs e)
        {
            double nota = double.Parse(textBoxNotaLista.Text);
            listEstudiante = src.ObtenerEstudiantesNotasSup(nota);
            dgvListado.DataSource = null;
            dgvListado.DataSource = listEstudiante;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listEstudiante = src.OrdenarEstudiantesPorNota();
            dgvListado.DataSource = null;
            dgvListado.DataSource = listEstudiante;
        }
    }
}
