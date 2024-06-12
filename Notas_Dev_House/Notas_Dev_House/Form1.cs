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
    public partial class Form1 : Form
    {
        NegocioSql cn = new NegocioSql();
        private bool super;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();

            //int numero = cn.CrudUsuarios(5, "2", Usuario.Text, Contra.Text);


            //if (cn.CrudUsuarios(5,"2",Usuario.Text,Contra.Text)==1 )
            //{
            //    MessageBox.Show("El SUPERusuario ha sido encontrado");
            //    this.Hide();
            //    ventanaPrincipal.Show();
            //    super = true;
            //}
            //else if (cn.CrudUsuarios(5, "2", Usuario.Text, Contra.Text) == 2)
            //{
            //    MessageBox.Show("El usuario ha sido encontrado");
            this.Hide();
            ventanaPrincipal.Show();
            //    super = false;
            //}
            //else
            //{
            //    MessageBox.Show("El usuario NO ha sido encontrado");
            //}






        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
