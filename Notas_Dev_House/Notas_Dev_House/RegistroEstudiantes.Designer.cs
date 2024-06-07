namespace Notas_Dev_House
{
    partial class RegistroEstudiantes
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
            this.nombres_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.apellidos_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fecha_nacimiento_txtt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.direccion_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.telefono_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buscador_id_text = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grado_txt = new System.Windows.Forms.TextBox();
            this.fecha_nacimiento_txt = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fecha_nacimiento_txt.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fecha_nacimiento_txt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(825, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nombres_txt
            // 
            this.nombres_txt.Location = new System.Drawing.Point(35, 353);
            this.nombres_txt.Name = "nombres_txt";
            this.nombres_txt.Size = new System.Drawing.Size(143, 20);
            this.nombres_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellidos";
            // 
            // apellidos_txt
            // 
            this.apellidos_txt.Location = new System.Drawing.Point(200, 353);
            this.apellidos_txt.Name = "apellidos_txt";
            this.apellidos_txt.Size = new System.Drawing.Size(143, 20);
            this.apellidos_txt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Identificacion";
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(363, 353);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(143, 20);
            this.id_txt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(531, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de nacimiento";
            // 
            // fecha_nacimiento_txtt
            // 
            this.fecha_nacimiento_txtt.Location = new System.Drawing.Point(513, 484);
            this.fecha_nacimiento_txtt.Name = "fecha_nacimiento_txtt";
            this.fecha_nacimiento_txtt.Size = new System.Drawing.Size(143, 20);
            this.fecha_nacimiento_txtt.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Direccion";
            // 
            // direccion_txt
            // 
            this.direccion_txt.Location = new System.Drawing.Point(34, 418);
            this.direccion_txt.Name = "direccion_txt";
            this.direccion_txt.Size = new System.Drawing.Size(143, 20);
            this.direccion_txt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefono";
            // 
            // telefono_txt
            // 
            this.telefono_txt.Location = new System.Drawing.Point(200, 418);
            this.telefono_txt.Name = "telefono_txt";
            this.telefono_txt.Size = new System.Drawing.Size(143, 20);
            this.telefono_txt.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(414, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(575, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 52);
            this.button2.TabIndex = 14;
            this.button2.Text = "MODIFICAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(725, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 52);
            this.button3.TabIndex = 15;
            this.button3.Text = "ELIMINAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(725, 467);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 52);
            this.button4.TabIndex = 16;
            this.button4.Text = "CERRAR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(200, 467);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(102, 52);
            this.button5.TabIndex = 17;
            this.button5.Text = "BUSCAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 467);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Nombre a buscar:";
            // 
            // buscador_id_text
            // 
            this.buscador_id_text.Location = new System.Drawing.Point(35, 499);
            this.buscador_id_text.Name = "buscador_id_text";
            this.buscador_id_text.Size = new System.Drawing.Size(143, 20);
            this.buscador_id_text.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(700, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Grado:";
            // 
            // grado_txt
            // 
            this.grado_txt.Location = new System.Drawing.Point(703, 353);
            this.grado_txt.Name = "grado_txt";
            this.grado_txt.Size = new System.Drawing.Size(143, 20);
            this.grado_txt.TabIndex = 20;
            // 
            // fecha_nacimiento_txt
            // 
            this.fecha_nacimiento_txt.EditValue = null;
            this.fecha_nacimiento_txt.Location = new System.Drawing.Point(534, 352);
            this.fecha_nacimiento_txt.Name = "fecha_nacimiento_txt";
            this.fecha_nacimiento_txt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fecha_nacimiento_txt.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fecha_nacimiento_txt.Size = new System.Drawing.Size(122, 20);
            this.fecha_nacimiento_txt.TabIndex = 22;
            // 
            // RegistroEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 552);
            this.Controls.Add(this.fecha_nacimiento_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grado_txt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buscador_id_text);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telefono_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.direccion_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fecha_nacimiento_txtt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.apellidos_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombres_txt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RegistroEstudiantes";
            this.Text = "RegistroEstudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fecha_nacimiento_txt.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fecha_nacimiento_txt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox nombres_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox apellidos_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fecha_nacimiento_txtt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox direccion_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telefono_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox buscador_id_text;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox grado_txt;
        private DevExpress.XtraEditors.DateEdit fecha_nacimiento_txt;
    }
}