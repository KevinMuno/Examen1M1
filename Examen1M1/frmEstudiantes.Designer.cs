namespace Examen1M1
{
    partial class frmEstudiantes
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(243, 41);
            label1.Name = "label1";
            label1.Size = new Size(341, 25);
            label1.TabIndex = 0;
            label1.Text = "ELIGA QUE TIPO DE ESTUDIANTE ES: ";
            // 
            // button1
            // 
            button1.Location = new Point(65, 126);
            button1.Name = "button1";
            button1.Size = new Size(265, 67);
            button1.TabIndex = 1;
            button1.Text = "ESTUDIANTE REGULAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(466, 126);
            button2.Name = "button2";
            button2.Size = new Size(265, 67);
            button2.TabIndex = 2;
            button2.Text = "ESTUDIANTE PREGRADO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmEstudiantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 252);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "frmEstudiantes";
            Text = "frmEstudiantes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}