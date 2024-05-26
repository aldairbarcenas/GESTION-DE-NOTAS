using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        DateTime Fecha_Nacimiento_Datetime;
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


            //cn.insertarEstudiante(id_txt.Text, nombres_txt.Text, apellidos_txt.Text,Fecha_Nacimiento, direccion_txt.Text, telefono_txt.Text);
            //dataGridView1.DataSource = cn.ConsultaDt();
            DateTime.TryParseExact(fecha_nacimiento_txt.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out Fecha_Nacimiento_Datetime);

            cn.CrudEstudiante(2, id_txt.Text, nombres_txt.Text, apellidos_txt.Text, Fecha_Nacimiento_Datetime, direccion_txt.Text, telefono_txt.Text);
            Console.WriteLine("SI LO MANDO ");
            dataGridView1.DataSource = cn.ConsultaDt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fecha_Nacimiento_Datetime = DateTime.ParseExact(fecha_nacimiento_txt.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            cn.CrudEstudiante(3, id_txt.Text, nombres_txt.Text, apellidos_txt.Text, Fecha_Nacimiento_Datetime, direccion_txt.Text, telefono_txt.Text);
            dataGridView1.DataSource = cn.ConsultaDt();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.EliminarEstudiante(4,id_txt.Text);
            dataGridView1.DataSource = cn.ConsultaDt();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
