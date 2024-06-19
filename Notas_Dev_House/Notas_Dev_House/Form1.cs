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
        public bool esSuperUsuario;
        public Form1()
        {
            InitializeComponent();          


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string nombreUsuario = Usuario.Text;
            string contrasena = Contra.Text;
            esSuperUsuario = false;

            if (cn.CrudUsuarios(5,"",nombreUsuario, contrasena, esSuperUsuario,out esSuperUsuario))
            {
                if (esSuperUsuario)
                {
                    // Usuario es superusuario
                    MessageBox.Show("¡Bienvenido, superusuario!");
                    esSuperUsuario = true;
                }
                else
                {
                    // Usuario no es superusuario
                    MessageBox.Show("¡Bienvenido!");
                }
                this.Hide();
                VentanaPrincipal ventanaPrincipal = new VentanaPrincipal(esSuperUsuario);
                ventanaPrincipal.Show();
                
            }
            else
            {
                MessageBox.Show("Error: Usuario o contraseña incorrectos.");

                this.Hide();
                VentanaPrincipal ventanaPrincipal = new VentanaPrincipal(esSuperUsuario);
                ventanaPrincipal.Show();
            }

            Usuario.Text = string.Empty;
            Contra.Text = string.Empty;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            this.Hide();
            NuevoUsuario user = new NuevoUsuario();
            user.ShowDialog();
            this.Show();
        }
    }
}
