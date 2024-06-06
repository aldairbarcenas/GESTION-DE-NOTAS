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
            // Cargar los datos iniciales del ComboBox Grado
            DataSet dataSet = cn.CargarDatosComboBox(null, null, 1, 1, "null");
            ComboGrado.DataSource = dataSet.Tables[2];
            ComboGrado.DisplayMember = "Id";



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

        private void Cambiar_Index_Grado(object sender, EventArgs e)
        {
            
        }

        private void CambiaEstudianteIndex(object sender, EventArgs e)
        {
            

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
