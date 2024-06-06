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
        
        NegocioSql cn = new NegocioSql();       
        private bool cambiogrado = false;
        
        public RegistroNotas()
        {
           
            InitializeComponent();

            // Cargar los datos iniciales del ComboBox Grado           
           
                DataSet dataSet = cn.CargarDatosComboBox(null, null, 1, 1, "null");
                ComboGrado.DataSource = dataSet.Tables[2];
                ComboGrado.DisplayMember = "Id";
                ComboPeriodo.DataSource = dataSet.Tables[5];
                ComboPeriodo.DisplayMember = "Id";
                ComboGrado.SelectedIndex = -1;       
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    private void Seleccionar_Grado(object sender, EventArgs e) //cuando cambia por click
        {
            



        }

        private void CambiaEstudiante(object sender, EventArgs e) //cuando cambia por codigo
        {
            

        }

        private void Cambiar_Index_Grado(object sender, EventArgs e) //index grado
        {

           
                if (int.TryParse(ComboGrado.Text, out int grado) ) //convertimos lo que hay en grado en entetero
                                                                  //si se realiza correctamente sale un true
                {

                    DataSet dataSet = cn.CargarDatosComboBox(null, null, grado, 1, "sssss"); //cargamos el combobox aun no escojemos nombre de estudiante
                    //mostramos los nombres de los estudiantes
                    ComboEstudiante.DataSource = dataSet.Tables[4];
                    ComboEstudiante.DisplayMember = "Nombres";
                    
                   //mostramos el periodo
                    ComboPeriodo.DataSource = dataSet.Tables[5];
                    ComboPeriodo.DisplayMember = "Id";
                    //mostramos todas las materias del grado
                    ComboMaterias.DataSource = dataSet.Tables[6];
                    ComboMaterias.DisplayMember = "Nombre";

                    //mandamos el nombre del estudiante que trajo automatico al seleccionar un grado                                        
                    DataSet dataSet1 = cn.CargarDatosComboBox(null, null, grado, 1, ComboEstudiante.Text); //cargamos el combobox
                    string idEstudiante = dataSet1.Tables[7].Rows[0]["ID"].ToString();
                    txt_ID_Estudiante.Text = idEstudiante;

                    cambiogrado = true; //aseguramos que entre aqui primero

                }

                
            
          

        }

        private void CambiaEstudianteIndex(object sender, EventArgs e) //afadifaiduhfpiaudhfdpuifhapiudafhipd
        {

           
            if ( cambiogrado==true) 
            {
                int grado = Convert.ToInt32(ComboGrado.Text);
                DataSet dataSet = cn.CargarDatosComboBox(null, null, grado, 1, ComboEstudiante.Text); //cargamos el combobox
                string idEstudiante = dataSet.Tables[7].Rows[0]["ID"].ToString();
                txt_ID_Estudiante.Text = idEstudiante;
            }

            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

        }

        private void ComboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClickEstudiante(object sender, EventArgs e)
        {
            
        }
    }
}
