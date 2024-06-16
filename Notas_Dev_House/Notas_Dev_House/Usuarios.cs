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
        //public Usuarios()
        //{
        //    InitializeComponent();
        //    //login.ShowDialog();
        //    esSuperUsuario = login.esSuperUsuario;

        //    Superusuario.SelectedIndex = 0;
        //    dataGridView1.DataSource = cn.ConsultarUsuarios(1, IdUsuario.Text);

        //    if (esSuperUsuario == false)
        //    {
        //        Superusuario.Visible = false;
        //        superUsuario_text.Visible = false;
        //    }


        //}

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
    }
}
