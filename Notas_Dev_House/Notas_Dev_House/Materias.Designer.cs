namespace Notas_Dev_House
{
    partial class Materias
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
            this.label1 = new System.Windows.Forms.Label();
            this.Id_Materias_text = new System.Windows.Forms.TextBox();
            this.txt_materia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Especialidad_Combo = new System.Windows.Forms.ComboBox();
            this.Docente_Combo = new System.Windows.Forms.ComboBox();
            this.GradoCombo = new System.Windows.Forms.ComboBox();
            this.Id_docente_text = new System.Windows.Forms.TextBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(617, 270);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Materias:";
            // 
            // Id_Materias_text
            // 
            this.Id_Materias_text.Location = new System.Drawing.Point(21, 431);
            this.Id_Materias_text.Name = "Id_Materias_text";
            this.Id_Materias_text.Size = new System.Drawing.Size(100, 22);
            this.Id_Materias_text.TabIndex = 2;
            this.Id_Materias_text.TextChanged += new System.EventHandler(this.Id_Materias_text_TextChanged);
            // 
            // txt_materia
            // 
            this.txt_materia.Location = new System.Drawing.Point(21, 357);
            this.txt_materia.Name = "txt_materia";
            this.txt_materia.Size = new System.Drawing.Size(100, 22);
            this.txt_materia.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Materia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Docente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(646, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Grado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nombre Docente:";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(193, 401);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(101, 52);
            this.btn_agregar.TabIndex = 11;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Especialidad:";
            // 
            // Especialidad_Combo
            // 
            this.Especialidad_Combo.FormattingEnabled = true;
            this.Especialidad_Combo.Location = new System.Drawing.Point(156, 355);
            this.Especialidad_Combo.Name = "Especialidad_Combo";
            this.Especialidad_Combo.Size = new System.Drawing.Size(121, 24);
            this.Especialidad_Combo.TabIndex = 13;
            // 
            // Docente_Combo
            // 
            this.Docente_Combo.FormattingEnabled = true;
            this.Docente_Combo.Location = new System.Drawing.Point(313, 357);
            this.Docente_Combo.Name = "Docente_Combo";
            this.Docente_Combo.Size = new System.Drawing.Size(121, 24);
            this.Docente_Combo.TabIndex = 15;
            this.Docente_Combo.SelectedIndexChanged += new System.EventHandler(this.Docente_Combo_SelectedIndexChanged);
            // 
            // GradoCombo
            // 
            this.GradoCombo.FormattingEnabled = true;
            this.GradoCombo.Location = new System.Drawing.Point(649, 357);
            this.GradoCombo.Name = "GradoCombo";
            this.GradoCombo.Size = new System.Drawing.Size(121, 24);
            this.GradoCombo.TabIndex = 16;
            // 
            // Id_docente_text
            // 
            this.Id_docente_text.Location = new System.Drawing.Point(469, 357);
            this.Id_docente_text.Name = "Id_docente_text";
            this.Id_docente_text.ReadOnly = true;
            this.Id_docente_text.Size = new System.Drawing.Size(100, 22);
            this.Id_docente_text.TabIndex = 17;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(322, 401);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(101, 52);
            this.btn_modificar.TabIndex = 18;
            this.btn_modificar.Text = "MODIFICAR";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(442, 401);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(101, 52);
            this.btn_eliminar.TabIndex = 19;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(585, 401);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(101, 52);
            this.btn_cerrar.TabIndex = 20;
            this.btn_cerrar.Text = "CERRAR";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 489);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.Id_docente_text);
            this.Controls.Add(this.GradoCombo);
            this.Controls.Add(this.Docente_Combo);
            this.Controls.Add(this.Especialidad_Combo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_materia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Id_Materias_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Materias";
            this.Text = "Materias";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Id_Materias_text;
        private System.Windows.Forms.TextBox txt_materia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Especialidad_Combo;
        private System.Windows.Forms.ComboBox Docente_Combo;
        private System.Windows.Forms.ComboBox GradoCombo;
        private System.Windows.Forms.TextBox Id_docente_text;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cerrar;
    }
}