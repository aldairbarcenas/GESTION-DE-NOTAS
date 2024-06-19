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
    public partial class ReporteMateria : Form
    {
        NegocioSql cn = new NegocioSql();
        public ReporteMateria()
        {
            InitializeComponent();
            DataSet dataSet = cn.CargarDatosComboBox(null, null, 1, 1, null, null);

            if (dataSet != null && dataSet.Tables.Count > 0)
            {
                comboBox2.DataSource = dataSet.Tables[10];
                comboBox2.DisplayMember = "Nombre";
                comboBox2.ValueMember = "Id";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)comboBox2.SelectedItem;
                string materiaId = selectedRow["Id"].ToString();
                dataGridView1.DataSource = cn.ReporteMaterias(materiaId);
            }
        }

        private void ReporteMateria_Load(object sender, EventArgs e)
        {

        }
    }
}
