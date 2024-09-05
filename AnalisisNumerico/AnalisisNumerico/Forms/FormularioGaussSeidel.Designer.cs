namespace AnalisisNumerico.Forms
{
    partial class FormularioGaussSeidel
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
            button2 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(32, 30, 45);
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(223, 223, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(294, 54);
            label1.TabIndex = 0;
            label1.Text = "GAUSS-SEIDEL";
            // 
            // button2
            // 
            button2.Location = new Point(756, 67);
            button2.Name = "button2";
            button2.Size = new Size(136, 37);
            button2.TabIndex = 14;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(614, 67);
            button4.Name = "button4";
            button4.Size = new Size(136, 37);
            button4.TabIndex = 13;
            button4.Text = "Generar matriz";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(510, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(52, 31);
            textBox1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(223, 225, 210);
            label3.Location = new Point(12, 63);
            label3.Name = "label3";
            label3.Size = new Size(492, 41);
            label3.TabIndex = 11;
            label3.Text = "Ingrese la dimensión de la matriz:";
            // 
            // FormularioGaussSeidel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(975, 548);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FormularioGaussSeidel";
            Text = "FormularioGaussSeidel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button2;
        private Button button4;
        private TextBox textBox1;
        private Label label3;
    }
}