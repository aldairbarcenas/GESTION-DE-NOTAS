using BLL;
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
    public partial class Usuarios : Form
    {
        NegocioSql cn = new NegocioSql();
        public Usuarios()
        {
            InitializeComponent();
            Superusuario.SelectedIndex = 0;
            dataGridView1.DataSource = cn.ConsultarUsuarios(1, IdUsuario.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
