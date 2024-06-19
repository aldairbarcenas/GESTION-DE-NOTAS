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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Notas_Dev_House
{
    public partial class Reportes : Form
    {
        NegocioSql cn = new NegocioSql();
        public Reportes()
        {
            InitializeComponent();
            DataSet dataSet = cn.CargarDatosComboBox(null, null, 1, 1, null, null);

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                estudiante_combo.DataSource = dataSet.Tables[9];
                estudiante_combo.DisplayMember = "Nombres";
                estudiante_combo.ValueMember = "Id";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (estudiante_combo.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)estudiante_combo.SelectedItem;
                string estudianteId = selectedRow["Id"].ToString();
                dataGridView1.DataSource = cn.ReporteEstudiantes(estudianteId);
            }
            
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

        }

        private void estudiante_combo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
