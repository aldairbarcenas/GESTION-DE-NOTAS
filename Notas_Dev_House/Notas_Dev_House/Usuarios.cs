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
        Form1 login = new Form1();
    


        private bool esSuperUsuario;
        private bool intsuper;


        public Usuarios(bool esSuperUsuario)
        {
            InitializeComponent();


           

            this.esSuperUsuario = esSuperUsuario;

            

            Superusuario.SelectedIndex = 0;
           
            dataGridView1.DataSource = cn.ConsultarUsuarios(1, IdUsuario.Text);

            if (!esSuperUsuario)
            {
                Superusuario.Visible = false;
                superUsuario_text.Visible = false;
            }
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

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Superusuario.Text) || Superusuario.Text == "NO")
            {
                intsuper = false;
            }
            else if (Superusuario.Text == "SI")
            {
                intsuper = true;
            }


            cn.CrudUsuarios(2, IdUsuario.Text, Usuario.Text, Contra.Text, intsuper, out esSuperUsuario);
            dataGridView1.DataSource = cn.ConsultarUsuarios(1, IdUsuario.Text);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Superusuario.Text) || Superusuario.Text == "NO")
            {
                intsuper = false;
            }
            else if (Superusuario.Text == "SI")
            {
                intsuper = true;
            }


            cn.CrudUsuarios(3, IdUsuario.Text, Usuario.Text, Contra.Text, intsuper,out esSuperUsuario);
            dataGridView1.DataSource = cn.ConsultarUsuarios(1, IdUsuario.Text);
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Superusuario.Text) || Superusuario.Text == "NO")
            {
                intsuper = false;
            }
            else if (Superusuario.Text == "SI")
            {
                intsuper = true;
            }


            cn.CrudUsuarios(4, IdUsuario.Text, Usuario.Text, Contra.Text, intsuper, out esSuperUsuario);
            dataGridView1.DataSource = cn.ConsultarUsuarios(1, IdUsuario.Text);
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }
    }
}
