using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas_Dev_House
{
    public partial class VentanaPrincipal : Form
    {
        private bool esSuperUsuario;
        public VentanaPrincipal()
        {
            InitializeComponent();
        }
        public VentanaPrincipal(bool esSuperUsuario)
        {
            InitializeComponent();
            this.esSuperUsuario = esSuperUsuario;
        }


        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroEstudiantes registroEstudiantes = new RegistroEstudiantes();
            registroEstudiantes.ShowDialog();
            this.Show();
        }

        private void gradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Grados grados = new Grados();
            grados.ShowDialog();
            this.Show();

        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Materias materias = new Materias();
            materias.ShowDialog();
            this.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroNotas notas = new RegistroNotas();
            notas.ShowDialog();
            this.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios user = new Usuarios(esSuperUsuario);
            user.ShowDialog();
            this.Show();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Docentes doc = new Docentes();
            doc.ShowDialog();
            this.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reportes doc = new Reportes();
            doc.ShowDialog();
            this.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteMateria doc = new ReporteMateria();
            doc.ShowDialog();
            this.Show();
        }

        private void gradoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReporteGrados doc = new ReporteGrados();
            doc.ShowDialog();
            this.Show();
        }

        private void gradoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RendimientoGrado doc = new RendimientoGrado();
            doc.ShowDialog();
            this.Show();
        }
    }
}
