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
    public partial class Materias : Form
    {
        NegocioSql cn = new NegocioSql();
        private bool isLoading = false;

        public Materias()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultarMaterias(1, 888888888); //los 8888888 es para asegurar que se consulte al iiniciar,
                                                                           //considero que no existira una materia con ese ID aleatorio
            CargarDatosComboBox();
            Especialidad_Combo.SelectedIndexChanged += EspecialidadCombo_SelectedIndexChanged; 
            //cada vez que hay un cambio en la especialidad se carga la informacion en los combox
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Id_Materias_text_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            
        }

        private void CargarDatosComboBox() //metodo para cargar los datos
        {
            try
            {
                isLoading = true; //cambiamos la bandera

                string especialidad = Especialidad_Combo.Text;

                
                Docente_Combo.SelectionChangeCommitted -= NombreDocenteCombo_SelectionChangeCommitted;
                //quitamos la asociacion al evento cuando selecianmos el docente, para q no se dispare
                //esto para sacar el ID cada que cambiamos al docente
                DataSet dataSet = cn.CargarDatosComboBox(especialidad, null);

                if (dataSet != null && dataSet.Tables.Count > 0) //si es diferente de null
                    //y trae al menos una tabla
                {
                    Especialidad_Combo.DataSource = dataSet.Tables[0];
                    Especialidad_Combo.DisplayMember = "Especialidad";

                    Docente_Combo.DataSource = dataSet.Tables[1];
                    Docente_Combo.DisplayMember = "NombreCompleto";

                    // Suscribir nuevamente al evento para obtener el ID
                    Docente_Combo.SelectionChangeCommitted += NombreDocenteCombo_SelectionChangeCommitted;
                    //este es el ID de grados
                    GradoCombo.DataSource = dataSet.Tables[2];
                    GradoCombo.DisplayMember = "Id";
                }
                else
                {
                    MessageBox.Show("Error al cargar los datos en los ComboBoxes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos en los ComboBoxes: " + ex.Message);
            }
            finally
            {
                isLoading = false;
            }
        }

        // Método para manejar la selección de nombres de docentes
        private void NombreDocenteCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            string nombreDocente = Docente_Combo.Text;            
            DataSet dataSet = cn.CargarDatosComboBox(Especialidad_Combo.Text, nombreDocente);

            // Mostrar el ID del docente en el TextBox correspondiente
            if (dataSet != null && dataSet.Tables.Count > 0 && dataSet.Tables[3].Rows.Count > 0)
            {
                string idDocente = dataSet.Tables[3].Rows[0]["Id"].ToString();
                Id_docente_text.Text = idDocente;
            }
            else
            {
                MessageBox.Show("Error al obtener el ID del docente.");
            }
        }

        private void EspecialidadCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosComboBox();
        }

        private void Docente_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Código adicional si es necesario
        }



    }
}
