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
    public partial class NuevoUsuario : Form
    {
        NegocioSql cn = new NegocioSql();
        private bool esSuperUsuario;
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
           
            if (cn.CrudUsuarios(2, IdUsuario.Text, Usuario.Text, Contra.Text, false, out esSuperUsuario) == true)
            {

                MessageBox.Show("Usuario creado Exitosamente");
                IdUsuario.Text = string.Empty;
                Usuario.Text = string.Empty;
                Contra.Text = string.Empty;

            }

            else
            {
                MessageBox.Show("El Id no corresponde ni a un alumno ni a un docente");
                IdUsuario.Text = string.Empty;
                Usuario.Text = string.Empty;
                Contra.Text = string.Empty;

            }
            

             

        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
         


            cn.CrudUsuarios(3, IdUsuario.Text, Usuario.Text, Contra.Text, false, out esSuperUsuario);
        }
    }
}
