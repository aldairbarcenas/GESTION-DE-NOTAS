using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Notas_Dev_House
{
    public partial class RegistroEstudiantes : Form
    {
        NegocioSql cn = new NegocioSql(); 
        public RegistroEstudiantes()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultaDt();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cn.insertarEstudiante(id_txt.Text, nombres_txt.Text, apellidos_txt.Text, fecha_nacimiento_txt.Text, direccion_txt.Text, telefono_txt.Text);
            dataGridView1.DataSource = cn.ConsultaDt();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.modificarEstudiante(nombres_txt.Text,apellidos_txt.Text,id_txt.Text,telefono_txt.Text,fecha_nacimiento_txt.Text,direccion_txt.Text);
            dataGridView1.DataSource = cn.ConsultaDt();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.eliminarEstudiante(id_txt.Text);
            dataGridView1.DataSource = cn.ConsultaDt();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
