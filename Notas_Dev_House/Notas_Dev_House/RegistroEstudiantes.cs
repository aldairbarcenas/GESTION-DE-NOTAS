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
            dataGridView1.DataSource = cn.ConsultaDt(nombres_txt.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.ConsultaDt(buscador_id_text.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            
            DateTime.TryParseExact(fecha_nacimiento_txt.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out Fecha_Nacimiento_Datetime);

            cn.CrudEstudiante(2, id_txt.Text, nombres_txt.Text, apellidos_txt.Text, Fecha_Nacimiento_Datetime, direccion_txt.Text, telefono_txt.Text,Convert.ToInt32( grado_txt.Text));
            Borrar_Campos();
            dataGridView1.DataSource = cn.ConsultaDt(nombres_txt.Text);
           



        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime.TryParseExact(fecha_nacimiento_txt.Text, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out Fecha_Nacimiento_Datetime);

            cn.CrudEstudiante(3, id_txt.Text, nombres_txt.Text, apellidos_txt.Text, Fecha_Nacimiento_Datetime, direccion_txt.Text, telefono_txt.Text, Convert.ToInt32(grado_txt.Text));
            Borrar_Campos();
            dataGridView1.DataSource = cn.ConsultaDt(nombres_txt.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cn.EliminarEstudiante(4,id_txt.Text);
            Borrar_Campos();
            dataGridView1.DataSource = cn.ConsultaDt(nombres_txt.Text);
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Borrar_Campos()
        {
            id_txt.Text = string.Empty;
            nombres_txt.Text= string.Empty;
            apellidos_txt.Text= string.Empty;
            fecha_nacimiento_txt.Text=string.Empty;
            direccion_txt.Text= string.Empty;
            telefono_txt.Text=string.Empty ;
            grado_txt.Text= string.Empty ;
        }


    }
}
