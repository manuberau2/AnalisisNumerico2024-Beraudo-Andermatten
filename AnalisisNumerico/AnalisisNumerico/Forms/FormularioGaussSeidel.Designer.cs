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
            BtnCalcular = new Button();
            BtnGenerarMatriz = new Button();
            TextBoxDimensionMatriz = new TextBox();
            label3 = new Label();
            label2 = new Label();
            TextboxTolerancia = new TextBox();
            label4 = new Label();
            TextBoxIteraciones = new TextBox();
            GroupBoxMatriz = new GroupBox();
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
            // BtnCalcular
            // 
            BtnCalcular.Location = new Point(784, 117);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(136, 37);
            BtnCalcular.TabIndex = 14;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = true;
            // 
            // BtnGenerarMatriz
            // 
            BtnGenerarMatriz.Location = new Point(784, 70);
            BtnGenerarMatriz.Name = "BtnGenerarMatriz";
            BtnGenerarMatriz.Size = new Size(136, 37);
            BtnGenerarMatriz.TabIndex = 13;
            BtnGenerarMatriz.Text = "Generar matriz";
            BtnGenerarMatriz.UseVisualStyleBackColor = true;
            BtnGenerarMatriz.Click += BtnGenerarMatriz_Click;
            // 
            // TextBoxDimensionMatriz
            // 
            TextBoxDimensionMatriz.Location = new Point(510, 67);
            TextBoxDimensionMatriz.Name = "TextBoxDimensionMatriz";
            TextBoxDimensionMatriz.Size = new Size(52, 31);
            TextBoxDimensionMatriz.TabIndex = 12;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(223, 225, 210);
            label2.Location = new Point(12, 113);
            label2.Name = "label2";
            label2.Size = new Size(169, 41);
            label2.TabIndex = 15;
            label2.Text = "Tolerancia:";
            // 
            // TextboxTolerancia
            // 
            TextboxTolerancia.Location = new Point(187, 123);
            TextboxTolerancia.Name = "TextboxTolerancia";
            TextboxTolerancia.Size = new Size(103, 31);
            TextboxTolerancia.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(223, 225, 210);
            label4.Location = new Point(316, 113);
            label4.Name = "label4";
            label4.Size = new Size(265, 41);
            label4.TabIndex = 17;
            label4.Text = "N° de iteraciones:";
            // 
            // TextBoxIteraciones
            // 
            TextBoxIteraciones.Location = new Point(596, 123);
            TextBoxIteraciones.Name = "TextBoxIteraciones";
            TextBoxIteraciones.Size = new Size(103, 31);
            TextBoxIteraciones.TabIndex = 18;
            // 
            // GroupBoxMatriz
            // 
            GroupBoxMatriz.ForeColor = Color.FromArgb(223, 225, 210);
            GroupBoxMatriz.Location = new Point(30, 174);
            GroupBoxMatriz.Name = "GroupBoxMatriz";
            GroupBoxMatriz.Size = new Size(933, 356);
            GroupBoxMatriz.TabIndex = 19;
            GroupBoxMatriz.TabStop = false;
            GroupBoxMatriz.Text = "Matriz";
            // 
            // FormularioGaussSeidel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(975, 548);
            Controls.Add(GroupBoxMatriz);
            Controls.Add(TextBoxIteraciones);
            Controls.Add(label4);
            Controls.Add(TextboxTolerancia);
            Controls.Add(label2);
            Controls.Add(BtnCalcular);
            Controls.Add(BtnGenerarMatriz);
            Controls.Add(TextBoxDimensionMatriz);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "FormularioGaussSeidel";
            Text = "FormularioGaussSeidel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnCalcular;
        private Button BtnGenerarMatriz;
        private TextBox TextBoxDimensionMatriz;
        private Label label3;
        private Label label2;
        private TextBox TextboxTolerancia;
        private Label label4;
        private TextBox TextBoxIteraciones;
        private GroupBox GroupBoxMatriz;
    }
}