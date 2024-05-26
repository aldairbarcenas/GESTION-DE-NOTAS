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
        public VentanaPrincipal()
        {
            InitializeComponent();
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
    }
}
