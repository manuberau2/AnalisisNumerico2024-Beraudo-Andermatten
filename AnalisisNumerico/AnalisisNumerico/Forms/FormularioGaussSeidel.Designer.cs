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
            button3 = new Button();
            button1 = new Button();
            TextBoxDimensionMatriz = new TextBox();
            label2 = new Label();
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
            // button3
            // 
            button3.Location = new Point(774, 81);
            button3.Name = "button3";
            button3.Size = new Size(136, 37);
            button3.TabIndex = 10;
            button3.Text = "Calcular";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(632, 81);
            button1.Name = "button1";
            button1.Size = new Size(136, 37);
            button1.TabIndex = 9;
            button1.Text = "Generar matriz";
            button1.UseVisualStyleBackColor = true;
            // 
            // TextBoxDimensionMatriz
            // 
            TextBoxDimensionMatriz.Location = new Point(529, 84);
            TextBoxDimensionMatriz.Name = "TextBoxDimensionMatriz";
            TextBoxDimensionMatriz.Size = new Size(52, 31);
            TextBoxDimensionMatriz.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(223, 225, 210);
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(524, 45);
            label2.TabIndex = 7;
            label2.Text = "Ingrese la dimensión de la matriz:";
            // 
            // FormularioGaussSeidel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(975, 548);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(TextBoxDimensionMatriz);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormularioGaussSeidel";
            Text = "FormularioGaussSeidel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button3;
        private Button button1;
        private TextBox TextBoxDimensionMatriz;
        private Label label2;
    }
}