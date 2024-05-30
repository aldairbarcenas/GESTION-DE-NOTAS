namespace Notas_Dev_House
{
    partial class RegistroNotas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ComboGrado = new System.Windows.Forms.ComboBox();
            this.ComboEstudiante = new System.Windows.Forms.ComboBox();
            this.ComboPeriodo = new System.Windows.Forms.ComboBox();
            this.ComboMaterias = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 227);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ComboGrado
            // 
            this.ComboGrado.FormattingEnabled = true;
            this.ComboGrado.Location = new System.Drawing.Point(45, 323);
            this.ComboGrado.Name = "ComboGrado";
            this.ComboGrado.Size = new System.Drawing.Size(121, 24);
            this.ComboGrado.TabIndex = 1;
            this.ComboGrado.SelectedIndexChanged += new System.EventHandler(this.Cambiar_Index_Grado);
            this.ComboGrado.SelectionChangeCommitted += new System.EventHandler(this.Seleccionar_Grado);
            // 
            // ComboEstudiante
            // 
            this.ComboEstudiante.FormattingEnabled = true;
            this.ComboEstudiante.Location = new System.Drawing.Point(192, 323);
            this.ComboEstudiante.Name = "ComboEstudiante";
            this.ComboEstudiante.Size = new System.Drawing.Size(121, 24);
            this.ComboEstudiante.TabIndex = 2;
            this.ComboEstudiante.SelectedIndexChanged += new System.EventHandler(this.CambiaEstudianteIndex);
            // 
            // ComboPeriodo
            // 
            this.ComboPeriodo.FormattingEnabled = true;
            this.ComboPeriodo.Location = new System.Drawing.Point(346, 323);
            this.ComboPeriodo.Name = "ComboPeriodo";
            this.ComboPeriodo.Size = new System.Drawing.Size(121, 24);
            this.ComboPeriodo.TabIndex = 3;
            // 
            // ComboMaterias
            // 
            this.ComboMaterias.FormattingEnabled = true;
            this.ComboMaterias.Location = new System.Drawing.Point(499, 323);
            this.ComboMaterias.Name = "ComboMaterias";
            this.ComboMaterias.Size = new System.Drawing.Size(121, 24);
            this.ComboMaterias.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Grado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estudiante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Periodo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Materias";
            // 
            // RegistroNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboMaterias);
            this.Controls.Add(this.ComboPeriodo);
            this.Controls.Add(this.ComboEstudiante);
            this.Controls.Add(this.ComboGrado);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RegistroNotas";
            this.Text = "RegistroNotas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ComboGrado;
        private System.Windows.Forms.ComboBox ComboEstudiante;
        private System.Windows.Forms.ComboBox ComboPeriodo;
        private System.Windows.Forms.ComboBox ComboMaterias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}