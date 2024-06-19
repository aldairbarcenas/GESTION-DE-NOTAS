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
    public partial class ReporteGrados : Form
    {
        NegocioSql cn = new NegocioSql();
        public ReporteGrados()
        {
            InitializeComponent();
            DataSet dataSet = cn.CargarDatosComboBox(null, null, 1, 1, null, null);

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                comboBox3.DataSource = dataSet.Tables[11];
                comboBox3.DisplayMember = "Nombre";
                comboBox3.ValueMember = "Id";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ReporteGrados_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)comboBox3.SelectedItem;
                int gradoId = Convert.ToInt32(selectedRow["Id"]);
                dataGridView1.DataSource = cn.ReporteGrados(gradoId);
            }
        }
    }
}
