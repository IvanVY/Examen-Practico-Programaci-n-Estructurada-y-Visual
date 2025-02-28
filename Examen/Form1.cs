using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionCalificaciones;
using static System.Collections.Specialized.BitVector32;

namespace Examen
{
    public partial class Form1 : Form
    {
        private GestionAlumnos gestion = new GestionAlumnos();

        public Form1()
        {
            InitializeComponent();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarAlumnos_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> alumnos = gestion.MostrarAlumnos();
                listBoxResultado.Items.Clear();
                foreach (var alumno in alumnos)
                {
                    listBoxResultado.Items.Add(alumno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón para introducir un nuevo alumno
        private void btnIntroducirAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDNI.Text;
                string apellidos = txtApellidos.Text;
                string nombre = txtNombre.Text;
                double nota = Convert.ToDouble(txtNota.Text);

                Alumno nuevoAlumno = new Alumno(dni, apellidos, nombre, nota);
                gestion.IntroducirAlumno(nuevoAlumno);

                MessageBox.Show("Alumno añadido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón para eliminar un alumno
        private void btnEliminarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDNI.Text;
                gestion.EliminarAlumno(dni);

                MessageBox.Show("Alumno eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsultarAlumno_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDNI.Text;
                Alumno alumno = gestion.ConsultarAlumno(dni);

                listBoxResultado.Items.Clear();
                listBoxResultado.Items.Add(alumno.MostrarInformacion());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarNota_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDNI.Text;
                double nuevaNota = Convert.ToDouble(txtNota.Text);

                gestion.ModificarNota(dni, nuevaNota);

                MessageBox.Show("Nota modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarSuspensos_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> suspensos = gestion.MostrarSuspensos();
                listBoxResultado.Items.Clear();
                foreach (var alumno in suspensos)
                {
                    listBoxResultado.Items.Add(alumno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarAprobados_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> aprobados = gestion.MostrarAprobados();
                listBoxResultado.Items.Clear();
                foreach (var alumno in aprobados)
                {
                    listBoxResultado.Items.Add(alumno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarCandidatosMH_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> mh = gestion.MostrarCandidatosMH();
                listBoxResultado.Items.Clear();
                foreach (var alumno in mh)
                {
                    listBoxResultado.Items.Add(alumno);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para limpiar los campos
        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtApellidos.Clear();
            txtNombre.Clear();
            txtNota.Clear();
        }
    }
}
