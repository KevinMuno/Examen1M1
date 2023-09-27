namespace Examen1M1
{
    partial class frmEstudianteRegular
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnRegistrar = new Button();
            btnNuevo = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtActitudinal = new TextBox();
            txtEva3 = new TextBox();
            txtEva2 = new TextBox();
            txtEva1 = new TextBox();
            txtEstudiante = new TextBox();
            label2 = new Label();
            lbEstadisticas = new ListBox();
            label7 = new Label();
            lvDetalles = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(219, 22);
            label1.Name = "label1";
            label1.Size = new Size(514, 30);
            label1.TabIndex = 0;
            label1.Text = "CONTROL DE EVALUACIONES - PROGRAMACION I";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtActitudinal);
            groupBox1.Controls.Add(txtEva3);
            groupBox1.Controls.Add(txtEva2);
            groupBox1.Controls.Add(txtEva1);
            groupBox1.Controls.Add(txtEstudiante);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(18, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(849, 116);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS DEL ESTUDIANTE";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(715, 65);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(115, 27);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(715, 32);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(115, 27);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "NUEVO DATO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(561, 34);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 9;
            label6.Text = "ACTITUDINAL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(479, 34);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 8;
            label5.Text = "EVA 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 34);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "EVA 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(320, 34);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 6;
            label3.Text = "EVA 1";
            // 
            // txtActitudinal
            // 
            txtActitudinal.Location = new Point(561, 60);
            txtActitudinal.Name = "txtActitudinal";
            txtActitudinal.Size = new Size(54, 23);
            txtActitudinal.TabIndex = 5;
            // 
            // txtEva3
            // 
            txtEva3.Location = new Point(479, 60);
            txtEva3.Name = "txtEva3";
            txtEva3.Size = new Size(54, 23);
            txtEva3.TabIndex = 4;
            // 
            // txtEva2
            // 
            txtEva2.Location = new Point(399, 60);
            txtEva2.Name = "txtEva2";
            txtEva2.Size = new Size(54, 23);
            txtEva2.TabIndex = 3;
            // 
            // txtEva1
            // 
            txtEva1.Location = new Point(317, 60);
            txtEva1.Name = "txtEva1";
            txtEva1.Size = new Size(54, 23);
            txtEva1.TabIndex = 2;
            // 
            // txtEstudiante
            // 
            txtEstudiante.Location = new Point(17, 60);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(274, 23);
            txtEstudiante.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 30);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 0;
            label2.Text = "ESTUDIANTE";
            // 
            // lbEstadisticas
            // 
            lbEstadisticas.FormattingEnabled = true;
            lbEstadisticas.ItemHeight = 15;
            lbEstadisticas.Location = new Point(18, 411);
            lbEstadisticas.Name = "lbEstadisticas";
            lbEstadisticas.Size = new Size(846, 124);
            lbEstadisticas.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 383);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 4;
            label7.Text = "ESTADISTICAS";
            // 
            // lvDetalles
            // 
            lvDetalles.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            lvDetalles.GridLines = true;
            lvDetalles.Location = new Point(20, 206);
            lvDetalles.Name = "lvDetalles";
            lvDetalles.Size = new Size(846, 137);
            lvDetalles.TabIndex = 5;
            lvDetalles.UseCompatibleStateImageBehavior = false;
            lvDetalles.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ESTUDIANTE";
            columnHeader1.Width = 260;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "EVA 1";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "EVA 2";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "EVA 3";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "ACTITUDINAL";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "PROMEDIO";
            columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "CONDICION";
            columnHeader7.Width = 160;
            // 
            // frmEstudianteRegular
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 567);
            Controls.Add(lvDetalles);
            Controls.Add(label7);
            Controls.Add(lbEstadisticas);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmEstudianteRegular";
            Text = "frmEstudianteRegular";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button btnRegistrar;
        private Button btnNuevo;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtActitudinal;
        private TextBox txtEva3;
        private TextBox txtEva2;
        private TextBox txtEva1;
        private TextBox txtEstudiante;
        private Label label2;
        private ListBox lbEstadisticas;
        private Label label7;
        private ListView lvDetalles;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}