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
        private bool cambiamateria = false;
        private bool cambiaestudiante = false;

        public RegistroNotas()
        {

            InitializeComponent();

            // Cargar los datos iniciales del ComboBox Grado           
            dataGridView1.DataSource = cn.ConsultarNotas(1, ComboEstudiante.Text, 243543669);
            DataSet dataSet = cn.CargarDatosComboBox(null, null, 1, 1, "null", "null");
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
            ComboMaterias.Text = string.Empty;
            //ComboGrado.Text= string.Empty;
            ComboPeriodo.Text = string.Empty;
            ComboEstudiante.Text = string.Empty;
            IdMateria_text.Text = string.Empty;
            txt_ID_Estudiante.Text = string.Empty;


            if (int.TryParse(ComboGrado.Text, out int grado)) //convertimos lo que hay en grado en entetero
                                                              //si se realiza correctamente sale un true
            {

                DataSet dataSet = cn.CargarDatosComboBox(null, null, grado, 1, "sssss", "null"); //cargamos el combobox aun no escojemos nombre de estudiante





                //mandamos el nombre del estudiante que trajo automatico al seleccionar un grado                                        
                DataSet dataSet1 = cn.CargarDatosComboBox(null, null, grado, 1, ComboEstudiante.Text, ComboMaterias.Text); //cargamos el combobox

                if (dataSet1.Tables[4].Rows.Count > 0)
                {
                    //mostramos los nombres de los estudiantes
                    ComboEstudiante.DataSource = dataSet.Tables[4];
                    ComboEstudiante.DisplayMember = "Nombres";
                    cambiaestudiante = true;
                }

                else
                {
                    cambiaestudiante = false;
                    ComboEstudiante.DataSource = null;
                    ComboEstudiante.Items.Clear();
                }

                if (dataSet1.Tables[5].Rows.Count > 0)
                {
                    //mostramos el periodo
                    ComboPeriodo.DataSource = dataSet.Tables[5];
                    ComboPeriodo.DisplayMember = "Id";
                }


                if (dataSet1.Tables[6].Rows.Count > 0)
                {
                    //mostramos todas las materias del grado
                    ComboMaterias.DataSource = dataSet.Tables[6];
                    ComboMaterias.DisplayMember = "Nombre";
                    cambiamateria = true;
                }

                else
                {
                    cambiamateria = false;
                    ComboMaterias.DataSource = null;
                    ComboMaterias.Items.Clear();

                }

                if (dataSet1.Tables[7].Rows.Count > 0)
                {
                    string idEstudiante = dataSet1.Tables[7].Rows[0]["ID"].ToString();
                    txt_ID_Estudiante.Text = idEstudiante;
                }


                if (dataSet1.Tables[8].Rows.Count > 0)
                {
                    string idMateria = dataSet1.Tables[8].Rows[0]["Id"].ToString();
                    IdMateria_text.Text = idMateria;
                }





                string quemateriaes = ComboMaterias.Text;


                cambiogrado = true; //aseguramos que entre aqui primero

            }



        }

        private void ValidarConsulta(DataSet dataset1)
        {





        }

        private void CambiaEstudianteIndex(object sender, EventArgs e) //afadifaiduhfpiaudhfdpuifhapiudafhipd
        {


            if (cambiogrado == true && cambiaestudiante == true)
            {

                int grado = Convert.ToInt32(ComboGrado.Text);
                DataSet dataSet = cn.CargarDatosComboBox(null, null, grado, 1, ComboEstudiante.Text, ComboMaterias.Text); //cargamos el combobox
                string idEstudiante = dataSet.Tables[7].Rows[0]["ID"].ToString();
                txt_ID_Estudiante.Text = idEstudiante;
                string IdMateria = IdMateria_text.Text;
                if (string.IsNullOrEmpty(IdMateria))
                {
                    IdMateria = "989898";
                    dataGridView1.DataSource = cn.ConsultarNotas(1, idEstudiante, Convert.ToInt32(IdMateria));
                }

                else
                {
                    dataGridView1.DataSource = cn.ConsultarNotas(1, idEstudiante, Convert.ToInt32(IdMateria));
                }



            }


        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            cn.CrudNotas(2, txt_ID_Estudiante.Text, Convert.ToInt32(IdMateria_text.Text), Convert.ToDouble(nota1.Text),
                Convert.ToDouble(nota2.Text), Convert.ToDouble(nota3.Text), observacion.Text, Convert.ToInt32(ComboPeriodo.Text), 0);
            dataGridView1.DataSource = cn.ConsultarNotas(1, "", 243543669);
        }

        private void ComboPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ClickEstudiante(object sender, EventArgs e)
        {

        }

        private void CambiarMateria(object sender, EventArgs e)
        {

            if (cambiogrado == true && cambiamateria == true)
            {

                int grado = Convert.ToInt32(ComboGrado.Text);
                DataSet dataSet = cn.CargarDatosComboBox(null, null, grado, 1, ComboEstudiante.Text, ComboMaterias.Text); //cargamos el combobox


                string idMateria = dataSet.Tables[8].Rows[0]["Id"].ToString();
                IdMateria_text.Text = idMateria;
                int intmateria = Convert.ToInt32(idMateria);


                dataGridView1.DataSource = cn.ConsultarNotas(1, txt_ID_Estudiante.Text, intmateria);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e) //modificar
        {
            cn.CrudNotas(3, txt_ID_Estudiante.Text, Convert.ToInt32(IdMateria_text.Text), Convert.ToDouble(nota1.Text),
               Convert.ToDouble(nota2.Text), Convert.ToDouble(nota3.Text), observacion.Text, Convert.ToInt32(ComboPeriodo.Text), 0);
            dataGridView1.DataSource = cn.ConsultarNotas(1, "", 243543669);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.CrudNotas(4, txt_ID_Estudiante.Text, Convert.ToInt32(IdMateria_text.Text), Convert.ToDouble("0"),
               Convert.ToDouble("0"), Convert.ToDouble("0"), observacion.Text, Convert.ToInt32(ComboPeriodo.Text), 0);
            dataGridView1.DataSource = cn.ConsultarNotas(1, "", 243543669);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
