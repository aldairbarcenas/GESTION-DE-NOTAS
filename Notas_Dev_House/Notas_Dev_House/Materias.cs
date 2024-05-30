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
            dataGridView1.DataSource = cn.ConsultarMaterias(1, 888888888);
            CargarDatosComboBox();
            Especialidad_Combo.SelectedIndexChanged += EspecialidadCombo_SelectedIndexChanged;
            ConfigurarAutoCompleteEspecialidad();  // Configurar el autocompletado
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Código adicional si es necesario
        }

        private void Id_Materias_text_TextChanged(object sender, EventArgs e)
        {
            // Código adicional si es necesario
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            cn.CrudMaterias(2, 332, txt_materia.Text, Id_docente_text.Text, Convert.ToInt32(GradoCombo.Text));
            Borrar_Campos();
            dataGridView1.DataSource = cn.ConsultarMaterias(1, 888888888);
        }

        private void CargarDatosComboBox()
        {
            try
            {
                isLoading = true;

                string especialidad = Especialidad_Combo.Text;

                // Desuscribir el evento para evitar que se dispare durante la actualización
                Docente_Combo.SelectionChangeCommitted -= NombreDocenteCombo_SelectionChangeCommitted;

                DataSet dataSet = cn.CargarDatosComboBox(especialidad, null, 1,1);

                if (dataSet != null && dataSet.Tables.Count > 0)
                {
                    // Guardar el índice seleccionado
                    int selectedEspecialidadIndex = Especialidad_Combo.SelectedIndex; //para que cambie

                    // Limpiar los elementos del ComboBox
                    Especialidad_Combo.DataSource = null;

                    // Asignar los datos y el miembro de visualización nuevamente
                    Especialidad_Combo.DataSource = dataSet.Tables[0];
                    Especialidad_Combo.DisplayMember = "Especialidad";

                    // Restaurar el índice seleccionado
                    Especialidad_Combo.SelectedIndex = selectedEspecialidadIndex;

                    Docente_Combo.DataSource = dataSet.Tables[1];
                    Docente_Combo.DisplayMember = "NombreCompleto";

                    // Volver a suscribir el evento
                    Docente_Combo.SelectionChangeCommitted += NombreDocenteCombo_SelectionChangeCommitted;
                    Docente_Combo.SelectedIndexChanged += Docente_Combo_SelectedIndexChanged;

                    GradoCombo.DataSource = dataSet.Tables[2];
                    GradoCombo.DisplayMember = "Id";

                    // Actualizar el AutoCompleteCustomSource después de cargar los datos
                    AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
                    foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        autoCompleteCollection.Add(row["Especialidad"].ToString());
                    }
                    Especialidad_Combo.AutoCompleteCustomSource = autoCompleteCollection;
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

        private void NombreDocenteCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string nombreDocente = Docente_Combo.Text;
            DataSet dataSet = cn.CargarDatosComboBox(Especialidad_Combo.Text, nombreDocente,1,1);

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
            if (isLoading) return;

            CargarDatosComboBox();
            
        }

        private void Docente_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreDocente = Docente_Combo.Text;
            DataSet dataSet = cn.CargarDatosComboBox(Especialidad_Combo.Text, nombreDocente, 1, 1   );

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

        private void ConfigurarAutoCompleteEspecialidad()
        {
            // Configurar las propiedades de autocompletado para el ComboBox de especialidad
            Especialidad_Combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            Especialidad_Combo.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void Borrar_Campos()
        {
            Id_Materias_text.Text = string.Empty;
            txt_materia.Text = string.Empty;
            Id_docente_text.Text = string.Empty;
            GradoCombo.Text = string.Empty;
            Docente_Combo.Text = string.Empty;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            cn.CrudMaterias(4, Convert.ToInt32(Id_Materias_text.Text), txt_materia.Text, Id_docente_text.Text, Convert.ToInt32(GradoCombo.Text));
            Borrar_Campos();
            dataGridView1.DataSource = cn.ConsultarMaterias(1, 888888888);
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            cn.CrudMaterias(3, Convert.ToInt32(Id_Materias_text.Text), txt_materia.Text, Id_docente_text.Text, Convert.ToInt32(GradoCombo.Text));
            Borrar_Campos();
            dataGridView1.DataSource = cn.ConsultarMaterias(1, 888888888);
        }
    }
}
