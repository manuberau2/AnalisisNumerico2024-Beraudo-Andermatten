namespace AnalisisNumerico.Forms
{
    partial class FormularioGaussJordan
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
            label2 = new Label();
            TextBoxDimensionMatriz = new TextBox();
            BtnGenerarMatriz = new Button();
            BtnCalcular = new Button();
            GroupBoxMatriz = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(32, 30, 45);
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(223, 223, 0);
            label1.Location = new Point(26, 23);
            label1.Name = "label1";
            label1.Size = new Size(330, 54);
            label1.TabIndex = 1;
            label1.Text = "GAUSS-JORDAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(223, 225, 210);
            label2.Location = new Point(2, 94);
            label2.Name = "label2";
            label2.Size = new Size(492, 41);
            label2.TabIndex = 2;
            label2.Text = "Ingrese la dimensión de la matriz:";
            // 
            // TextBoxDimensionMatriz
            // 
            TextBoxDimensionMatriz.Location = new Point(500, 101);
            TextBoxDimensionMatriz.Name = "TextBoxDimensionMatriz";
            TextBoxDimensionMatriz.Size = new Size(52, 31);
            TextBoxDimensionMatriz.TabIndex = 3;
            // 
            // BtnGenerarMatriz
            // 
            BtnGenerarMatriz.Location = new Point(584, 98);
            BtnGenerarMatriz.Name = "BtnGenerarMatriz";
            BtnGenerarMatriz.Size = new Size(136, 37);
            BtnGenerarMatriz.TabIndex = 4;
            BtnGenerarMatriz.Text = "Generar matriz";
            BtnGenerarMatriz.UseVisualStyleBackColor = true;
            BtnGenerarMatriz.Click += BtnGenerarMatriz_Click;
            // 
            // BtnCalcular
            // 
            BtnCalcular.Location = new Point(726, 98);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(136, 37);
            BtnCalcular.TabIndex = 6;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // GroupBoxMatriz
            // 
            GroupBoxMatriz.ForeColor = Color.FromArgb(223, 225, 210);
            GroupBoxMatriz.Location = new Point(26, 141);
            GroupBoxMatriz.Name = "GroupBoxMatriz";
            GroupBoxMatriz.Size = new Size(894, 395);
            GroupBoxMatriz.TabIndex = 7;
            GroupBoxMatriz.TabStop = false;
            GroupBoxMatriz.Text = "Matriz";
            // 
            // FormularioGaussJordan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(975, 548);
            Controls.Add(GroupBoxMatriz);
            Controls.Add(BtnCalcular);
            Controls.Add(BtnGenerarMatriz);
            Controls.Add(TextBoxDimensionMatriz);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormularioGaussJordan";
            Text = "FormularioGaussJordan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TextBoxDimensionMatriz;
        private Button BtnGenerarMatriz;
        private Button BtnCalcular;
        private GroupBox GroupBoxMatriz;
    }
}