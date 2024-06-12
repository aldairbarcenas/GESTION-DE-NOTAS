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
            this.nota1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nota2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nota3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.observacion = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ID_Estudiante = new System.Windows.Forms.TextBox();
            this.IdMateria_text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.dataGridView1.Size = new System.Drawing.Size(714, 227);
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
            this.ComboEstudiante.SelectionChangeCommitted += new System.EventHandler(this.ClickEstudiante);
            // 
            // ComboPeriodo
            // 
            this.ComboPeriodo.FormattingEnabled = true;
            this.ComboPeriodo.Location = new System.Drawing.Point(485, 323);
            this.ComboPeriodo.Name = "ComboPeriodo";
            this.ComboPeriodo.Size = new System.Drawing.Size(121, 24);
            this.ComboPeriodo.TabIndex = 3;
            this.ComboPeriodo.SelectedIndexChanged += new System.EventHandler(this.ComboPeriodo_SelectedIndexChanged);
            // 
            // ComboMaterias
            // 
            this.ComboMaterias.FormattingEnabled = true;
            this.ComboMaterias.Location = new System.Drawing.Point(638, 323);
            this.ComboMaterias.Name = "ComboMaterias";
            this.ComboMaterias.Size = new System.Drawing.Size(121, 24);
            this.ComboMaterias.TabIndex = 4;
            this.ComboMaterias.SelectedIndexChanged += new System.EventHandler(this.CambiarMateria);
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
            this.label3.Location = new System.Drawing.Point(482, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Periodo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Materias";
            // 
            // nota1
            // 
            this.nota1.Location = new System.Drawing.Point(102, 388);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(100, 22);
            this.nota1.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nota 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nota 2:";
            // 
            // nota2
            // 
            this.nota2.Location = new System.Drawing.Point(271, 388);
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(100, 22);
            this.nota2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(397, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nota 3:";
            // 
            // nota3
            // 
            this.nota3.Location = new System.Drawing.Point(448, 388);
            this.nota3.Name = "nota3";
            this.nota3.Size = new System.Drawing.Size(100, 22);
            this.nota3.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Observacion: ";
            // 
            // observacion
            // 
            this.observacion.Location = new System.Drawing.Point(147, 435);
            this.observacion.Multiline = true;
            this.observacion.Name = "observacion";
            this.observacion.Size = new System.Drawing.Size(519, 71);
            this.observacion.TabIndex = 17;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(45, 533);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(101, 56);
            this.btn_agregar.TabIndex = 18;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(331, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "ID Estudiante:";
            // 
            // txt_ID_Estudiante
            // 
            this.txt_ID_Estudiante.Location = new System.Drawing.Point(334, 324);
            this.txt_ID_Estudiante.Name = "txt_ID_Estudiante";
            this.txt_ID_Estudiante.ReadOnly = true;
            this.txt_ID_Estudiante.Size = new System.Drawing.Size(100, 22);
            this.txt_ID_Estudiante.TabIndex = 0;
            // 
            // IdMateria_text
            // 
            this.IdMateria_text.Location = new System.Drawing.Point(638, 388);
            this.IdMateria_text.Name = "IdMateria_text";
            this.IdMateria_text.ReadOnly = true;
            this.IdMateria_text.Size = new System.Drawing.Size(100, 22);
            this.IdMateria_text.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(635, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "ID Materia:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 56);
            this.button1.TabIndex = 23;
            this.button1.Text = "MODIFICAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(319, 533);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 56);
            this.button2.TabIndex = 24;
            this.button2.Text = "ELMINAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(658, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 56);
            this.button3.TabIndex = 25;
            this.button3.Text = "CERRAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // RegistroNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 611);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IdMateria_text);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_ID_Estudiante);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.observacion);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nota3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nota2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nota1);
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
        private System.Windows.Forms.TextBox nota1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nota2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nota3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox observacion;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ID_Estudiante;
        private System.Windows.Forms.TextBox IdMateria_text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}