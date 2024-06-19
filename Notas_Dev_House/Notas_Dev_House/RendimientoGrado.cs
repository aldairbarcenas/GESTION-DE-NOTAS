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
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using LiveCharts.Definitions.Charts;
using System.IO;
using System.Windows.Media;
using PdfSharp.Drawing;
using PdfSharp.Pdf;


namespace Notas_Dev_House
{
    public partial class RendimientoGrado : Form
    {
        NegocioSql cn = new NegocioSql();
        public RendimientoGrado()
        {
            InitializeComponent();
        }

        private void RendimientoGrado_Load(object sender, EventArgs e)
        {
            DataTable data = cn.RendimientoPorGrado();

            if (data != null && data.Rows.Count > 0)
            {
                SeriesCollection series = new SeriesCollection();
                foreach (DataRow row in data.Rows)
                {
                    string grado = row["Grado"].ToString(); // Obtener el nombre del grado
                    double promedio = Convert.ToDouble(row["PromedioGeneral"]); // Obtener el promedio

                    ColumnSeries columnSeries = new ColumnSeries
                    {
                        Values = new ChartValues<double> { promedio },
                        DataLabels = true, // Habilitar etiquetas de datos
                        LabelPoint = point => $"{point.Y:0.00}\n{grado}", // Texto personalizado para las etiquetas de datos
                        Foreground = System.Windows.Media.Brushes.Black // Color de texto
                    };
                    series.Add(columnSeries);
                }
                cartesianChart1.Series = series;

                // Establecer el título del eje X
                cartesianChart1.AxisX.Add(new Axis
                {
                    Title = "Grado"
                });

            }
    }

        private void GenerarPDF()
        {
            using (PdfDocument document = new PdfDocument())
            {
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);
                XFont font = new XFont("Arial", 12);
                gfx.DrawString("Reporte de Rendimiento por Grado", font, XBrushes.Black, new XRect(0, 0, page.Width.Point, page.Height.Point), XStringFormats.TopCenter);
                MemoryStream memoryStream = new MemoryStream();
                document.Save(memoryStream, false);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF Files|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(saveFileDialog.FileName, memoryStream.ToArray());
                }
            }
        }

    }
    
}
