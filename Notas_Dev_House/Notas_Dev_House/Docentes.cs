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
    public partial class Docentes : Form
    {
        NegocioSql cn = new NegocioSql();
        public Docentes()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultarDocentes(buscador_id_text.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.CrudDocente(2, id_txt.Text,nombreCompleto_txt.Text, FechaNacimiento.Value,direccion_txt.Text,telefono_txt.Text,especialidad_txt.Text);
            Borrar_Campos();
            dataGridView1.DataSource = cn.ConsultarDocentes(nombreCompleto_txt.Text);
        }


        private void Borrar_Campos()
        {
            id_txt.Text = string.Empty;
            nombreCompleto_txt.Text = string.Empty;          
            direccion_txt.Text = string.Empty;
            telefono_txt.Text = string.Empty;
            especialidad_txt.Text = string.Empty;
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            cn.CrudDocente(3, id_txt.Text, nombreCompleto_txt.Text, FechaNacimiento.Value, direccion_txt.Text, telefono_txt.Text, especialidad_txt.Text);
            Borrar_Campos();
            dataGridView1.DataSource = cn.ConsultarDocentes(nombreCompleto_txt.Text);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            cn.CrudDocente(4, id_txt.Text, nombreCompleto_txt.Text, FechaNacimiento.Value, direccion_txt.Text, telefono_txt.Text, especialidad_txt.Text);
            Borrar_Campos();
            dataGridView1.DataSource = cn.ConsultarDocentes(nombreCompleto_txt.Text);
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cn.ConsultarDocentes(buscador_id_text.Text);
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
