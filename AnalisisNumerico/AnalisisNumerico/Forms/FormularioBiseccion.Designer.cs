namespace AnalisisNumerico.Forms
{
    partial class FormularioBiseccion
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
            TextBoxFuncion = new TextBox();
            TextBoxIteraciones = new TextBox();
            TextBoxTolerancia = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            BtnCalcularRaiz = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(223, 225, 210);
            label1.Location = new Point(119, 9);
            label1.Name = "label1";
            label1.Size = new Size(442, 45);
            label1.TabIndex = 0;
            label1.Text = "MÉTODO DE LA BISECCIÓN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 131);
            label2.Name = "label2";
            label2.Size = new Size(0, 25);
            label2.TabIndex = 1;
            // 
            // TextBoxFuncion
            // 
            TextBoxFuncion.Location = new Point(27, 97);
            TextBoxFuncion.Name = "TextBoxFuncion";
            TextBoxFuncion.Size = new Size(193, 31);
            TextBoxFuncion.TabIndex = 2;
            // 
            // TextBoxIteraciones
            // 
            TextBoxIteraciones.Location = new Point(27, 175);
            TextBoxIteraciones.Name = "TextBoxIteraciones";
            TextBoxIteraciones.Size = new Size(193, 31);
            TextBoxIteraciones.TabIndex = 3;
            // 
            // TextBoxTolerancia
            // 
            TextBoxTolerancia.Location = new Point(27, 253);
            TextBoxTolerancia.Name = "TextBoxTolerancia";
            TextBoxTolerancia.Size = new Size(193, 31);
            TextBoxTolerancia.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(223, 225, 210);
            label3.Location = new Point(27, 62);
            label3.Name = "label3";
            label3.Size = new Size(125, 32);
            label3.TabIndex = 5;
            label3.Text = "FUNCIÓN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 236);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(223, 225, 210);
            label6.Location = new Point(27, 140);
            label6.Name = "label6";
            label6.Size = new Size(166, 32);
            label6.TabIndex = 8;
            label6.Text = "ITERACIONES:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(223, 225, 210);
            label4.Location = new Point(27, 218);
            label4.Name = "label4";
            label4.Size = new Size(161, 32);
            label4.TabIndex = 9;
            label4.Text = "TOLERANCIA:";
            // 
            // BtnCalcularRaiz
            // 
            BtnCalcularRaiz.Location = new Point(49, 312);
            BtnCalcularRaiz.Name = "BtnCalcularRaiz";
            BtnCalcularRaiz.Size = new Size(144, 40);
            BtnCalcularRaiz.TabIndex = 10;
            BtnCalcularRaiz.Text = "Calcular";
            BtnCalcularRaiz.UseVisualStyleBackColor = true;
            BtnCalcularRaiz.Click += BtnCalcularRaiz_Click;
            // 
            // FormularioBiseccion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(684, 435);
            Controls.Add(BtnCalcularRaiz);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(TextBoxTolerancia);
            Controls.Add(TextBoxIteraciones);
            Controls.Add(TextBoxFuncion);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormularioBiseccion";
            Text = "FormularioBiseccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TextBoxFuncion;
        private TextBox TextBoxIteraciones;
        private TextBox TextBoxTolerancia;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label4;
        private Button BtnCalcularRaiz;
    }
}