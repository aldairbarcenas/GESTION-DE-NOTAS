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
    public partial class RegistroNotas : Form
    {
        private bool isLoading = false;
        NegocioSql cn = new NegocioSql();
       

        public RegistroNotas()
        {
           
            InitializeComponent();

            // Configurar el evento para manejar la selección de grado
            ComboGrado.SelectedIndexChanged += (sender, e) => Seleccionar_Grado(sender, e);
            ComboEstudiante.SelectedIndexChanged += (sender, e) => CambiaEstudiante(sender, e);

            // Cargar los datos iniciales del ComboBox Grado
            DataSet dataSet = cn.CargarDatosComboBox(null, null, 1, 1);
            ComboGrado.DataSource = dataSet.Tables[2];
            ComboGrado.DisplayMember = "Id";

            // Guardar el índice actualmente seleccionado
            

            // para que inicie vacio el grado
            ComboGrado.SelectedIndex = -1;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void Seleccionar_Grado(object sender, EventArgs e) //cuando cambia por click
        {
            ComboMaterias.SelectedIndex = -1;   //para que cada vez inicie vacio         
            if (ComboGrado.SelectedIndex != -1) //si seleccione algo
            {
                if (int.TryParse(ComboGrado.Text, out int grado)) //convertimos lo que hay en grado en entetero
                    //si se realiza correctamente sale un true
                {
                    DataSet dataSet = cn.CargarDatosComboBox(null, null, grado, 1); //cargamos el combobox
                    //mostramos los nombres de los estudiantes
                    ComboEstudiante.DataSource = dataSet.Tables[4];
                    ComboEstudiante.DisplayMember = "Nombres";

                    ComboPeriodo.DataSource = dataSet.Tables[5];
                    ComboPeriodo.DisplayMember = "Id";

                    ComboMaterias.DataSource = dataSet.Tables[6];
                    ComboMaterias.DisplayMember = "Nombre";
                }
                
            }
        }

        private void CambiaEstudiante(object sender, EventArgs e) //cuando cambia por codigo
        {
                  


        }

        private void Cambiar_Index_Grado(object sender, EventArgs e)
        {
            
        }

        private void CambiaEstudianteIndex(object sender, EventArgs e)
        {

        }
    }
}
