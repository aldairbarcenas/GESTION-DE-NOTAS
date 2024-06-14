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
    public partial class Grados : Form
    {
        NegocioSql cn = new NegocioSql();
        public Grados()
        {
            InitializeComponent();
            dataGridView1.DataSource=cn.ConsultarGrados(1,1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            cn.CrudGrados(2,nombre_grado_txt.Text,id_grado_txt.Text);
            dataGridView1.DataSource = cn.ConsultarGrados(1, Convert.ToInt32(id_grado_txt.Text));
            Borrar_Campos();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            cn.CrudGrados(3, nombre_grado_txt.Text, id_grado_txt.Text);
            dataGridView1.DataSource = cn.ConsultarGrados(1, Convert.ToInt32(id_grado_txt.Text));
            Borrar_Campos();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void Borrar_Campos()
        {
            nombre_grado_txt.Text = string.Empty;
            id_grado_txt.Text = string.Empty;
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            cn.CrudGrados(4, nombre_grado_txt.Text, id_grado_txt.Text);
            dataGridView1.DataSource = cn.ConsultarGrados(1, Convert.ToInt32(id_grado_txt.Text));
            Borrar_Campos();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            string id = buscar_id_text.Text;

            if (string.IsNullOrEmpty(id))
            {
                dataGridView1.DataSource = cn.ConsultarGrados(1, 1);

            }
            else
            {
                dataGridView1.DataSource = cn.ConsultarGrados(5, Convert.ToInt32(buscar_id_text.Text));
                Borrar_Campos();
            }


            


            
        }
    }
}
