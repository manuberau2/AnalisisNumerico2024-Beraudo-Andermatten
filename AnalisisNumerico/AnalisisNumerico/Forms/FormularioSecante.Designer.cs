﻿namespace AnalisisNumerico.Forms
{
    partial class FormularioSecante
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
            LabelTitulo = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            TextBoxFuncion = new TextBox();
            BtnVerFuncion = new Button();
            BtnCalcularRaiz = new Button();
            TextBoxXd = new TextBox();
            label8 = new Label();
            label6 = new Label();
            TextBoxIteraciones = new TextBox();
            TextBoxXi = new TextBox();
            label7 = new Label();
            label4 = new Label();
            TextBoxTolerancia = new TextBox();
            groupBox2 = new GroupBox();
            label11 = new Label();
            TextBoxObservaciones = new TextBox();
            label9 = new Label();
            TextBoxXrResult = new TextBox();
            TextBoxErrorRelativoResult = new TextBox();
            TextBoxIteracionesResult = new TextBox();
            TextBoxConvergenciaResult = new TextBox();
            label1 = new Label();
            label10 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // LabelTitulo
            // 
            LabelTitulo.AutoSize = true;
            LabelTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitulo.ForeColor = Color.FromArgb(255, 128, 0);
            LabelTitulo.Location = new Point(151, 13);
            LabelTitulo.Margin = new Padding(2, 0, 2, 0);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(195, 54);
            LabelTitulo.TabIndex = 25;
            LabelTitulo.Text = "SECANTE";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TextBoxFuncion);
            groupBox1.Controls.Add(BtnVerFuncion);
            groupBox1.Controls.Add(BtnCalcularRaiz);
            groupBox1.Controls.Add(TextBoxXd);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(TextBoxIteraciones);
            groupBox1.Controls.Add(TextBoxXi);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(TextBoxTolerancia);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(223, 225, 210);
            groupBox1.Location = new Point(51, 69);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(416, 468);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entrada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(223, 225, 210);
            label3.Location = new Point(137, 24);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(125, 32);
            label3.TabIndex = 5;
            label3.Text = "FUNCIÓN:";
            // 
            // TextBoxFuncion
            // 
            TextBoxFuncion.Location = new Point(44, 60);
            TextBoxFuncion.Margin = new Padding(2);
            TextBoxFuncion.Name = "TextBoxFuncion";
            TextBoxFuncion.Size = new Size(333, 39);
            TextBoxFuncion.TabIndex = 2;
            TextBoxFuncion.Validating += TextBoxFuncion_Validating;
            // 
            // BtnVerFuncion
            // 
            BtnVerFuncion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVerFuncion.ForeColor = SystemColors.ControlText;
            BtnVerFuncion.Location = new Point(44, 358);
            BtnVerFuncion.Margin = new Padding(2);
            BtnVerFuncion.Name = "BtnVerFuncion";
            BtnVerFuncion.Size = new Size(332, 49);
            BtnVerFuncion.TabIndex = 10;
            BtnVerFuncion.Text = "Ver función";
            BtnVerFuncion.UseVisualStyleBackColor = true;
            BtnVerFuncion.Click += BtnVerFuncion_Click;
            // 
            // BtnCalcularRaiz
            // 
            BtnCalcularRaiz.ForeColor = SystemColors.ControlText;
            BtnCalcularRaiz.Location = new Point(44, 412);
            BtnCalcularRaiz.Margin = new Padding(2);
            BtnCalcularRaiz.Name = "BtnCalcularRaiz";
            BtnCalcularRaiz.Size = new Size(332, 49);
            BtnCalcularRaiz.TabIndex = 11;
            BtnCalcularRaiz.Text = "Calcular raíz";
            BtnCalcularRaiz.UseVisualStyleBackColor = true;
            BtnCalcularRaiz.Click += BtnCalcularRaiz_Click;
            // 
            // TextBoxXd
            // 
            TextBoxXd.Location = new Point(218, 312);
            TextBoxXd.Margin = new Padding(2);
            TextBoxXd.Name = "TextBoxXd";
            TextBoxXd.Size = new Size(160, 39);
            TextBoxXd.TabIndex = 14;
            TextBoxXd.KeyPress += TextBoxXd_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(223, 225, 210);
            label8.Location = new Point(277, 270);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(49, 32);
            label8.TabIndex = 15;
            label8.Text = "Xd:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(223, 225, 210);
            label6.Location = new Point(89, 111);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(236, 32);
            label6.TabIndex = 8;
            label6.Text = "N° DE ITERACIONES:";
            // 
            // TextBoxIteraciones
            // 
            TextBoxIteraciones.Location = new Point(44, 148);
            TextBoxIteraciones.Margin = new Padding(2);
            TextBoxIteraciones.Name = "TextBoxIteraciones";
            TextBoxIteraciones.Size = new Size(333, 39);
            TextBoxIteraciones.TabIndex = 3;
            TextBoxIteraciones.KeyPress += TextBoxIteraciones_KeyPress;
            TextBoxIteraciones.Validating += TextBoxIteraciones_Validating;
            // 
            // TextBoxXi
            // 
            TextBoxXi.Location = new Point(44, 312);
            TextBoxXi.Margin = new Padding(2);
            TextBoxXi.Name = "TextBoxXi";
            TextBoxXi.Size = new Size(160, 39);
            TextBoxXi.TabIndex = 12;
            TextBoxXi.KeyPress += TextBoxXi_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(223, 225, 210);
            label7.Location = new Point(109, 270);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(41, 32);
            label7.TabIndex = 13;
            label7.Text = "Xi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(223, 225, 210);
            label4.Location = new Point(120, 188);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(161, 32);
            label4.TabIndex = 9;
            label4.Text = "TOLERANCIA:";
            // 
            // TextBoxTolerancia
            // 
            TextBoxTolerancia.Location = new Point(44, 229);
            TextBoxTolerancia.Margin = new Padding(2);
            TextBoxTolerancia.Name = "TextBoxTolerancia";
            TextBoxTolerancia.Size = new Size(333, 39);
            TextBoxTolerancia.TabIndex = 4;
            TextBoxTolerancia.KeyPress += TextBoxTolerancia_KeyPress;
            TextBoxTolerancia.Validating += TextBoxTolerancia_Validating;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(TextBoxObservaciones);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(TextBoxXrResult);
            groupBox2.Controls.Add(TextBoxErrorRelativoResult);
            groupBox2.Controls.Add(TextBoxIteracionesResult);
            groupBox2.Controls.Add(TextBoxConvergenciaResult);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label12);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(223, 225, 210);
            groupBox2.Location = new Point(493, 12);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(430, 524);
            groupBox2.TabIndex = 23;
            groupBox2.TabStop = false;
            groupBox2.Text = "Salida";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(223, 225, 210);
            label11.Location = new Point(118, 347);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(206, 32);
            label11.TabIndex = 22;
            label11.Text = "OBSERVACIONES:";
            // 
            // TextBoxObservaciones
            // 
            TextBoxObservaciones.Location = new Point(52, 382);
            TextBoxObservaciones.Margin = new Padding(2);
            TextBoxObservaciones.Multiline = true;
            TextBoxObservaciones.Name = "TextBoxObservaciones";
            TextBoxObservaciones.ReadOnly = true;
            TextBoxObservaciones.ScrollBars = ScrollBars.Vertical;
            TextBoxObservaciones.Size = new Size(343, 122);
            TextBoxObservaciones.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(223, 225, 210);
            label9.Location = new Point(145, 270);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(162, 32);
            label9.TabIndex = 20;
            label9.Text = "VALOR DE Xr:";
            // 
            // TextBoxXrResult
            // 
            TextBoxXrResult.Location = new Point(52, 306);
            TextBoxXrResult.Margin = new Padding(2);
            TextBoxXrResult.Name = "TextBoxXrResult";
            TextBoxXrResult.ReadOnly = true;
            TextBoxXrResult.Size = new Size(333, 39);
            TextBoxXrResult.TabIndex = 19;
            // 
            // TextBoxErrorRelativoResult
            // 
            TextBoxErrorRelativoResult.Location = new Point(52, 229);
            TextBoxErrorRelativoResult.Margin = new Padding(2);
            TextBoxErrorRelativoResult.Name = "TextBoxErrorRelativoResult";
            TextBoxErrorRelativoResult.ReadOnly = true;
            TextBoxErrorRelativoResult.Size = new Size(333, 39);
            TextBoxErrorRelativoResult.TabIndex = 18;
            // 
            // TextBoxIteracionesResult
            // 
            TextBoxIteracionesResult.Location = new Point(52, 148);
            TextBoxIteracionesResult.Margin = new Padding(2);
            TextBoxIteracionesResult.Name = "TextBoxIteracionesResult";
            TextBoxIteracionesResult.ReadOnly = true;
            TextBoxIteracionesResult.Size = new Size(333, 39);
            TextBoxIteracionesResult.TabIndex = 17;
            // 
            // TextBoxConvergenciaResult
            // 
            TextBoxConvergenciaResult.Location = new Point(52, 70);
            TextBoxConvergenciaResult.Margin = new Padding(2);
            TextBoxConvergenciaResult.Name = "TextBoxConvergenciaResult";
            TextBoxConvergenciaResult.ReadOnly = true;
            TextBoxConvergenciaResult.Size = new Size(333, 39);
            TextBoxConvergenciaResult.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(223, 225, 210);
            label1.Location = new Point(145, 34);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(158, 32);
            label1.TabIndex = 5;
            label1.Text = "¿CONVERGE?";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(223, 225, 210);
            label10.Location = new Point(87, 111);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(266, 32);
            label10.TabIndex = 8;
            label10.Text = "ITERACIONES TOTALES:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(223, 225, 210);
            label12.Location = new Point(118, 193);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(209, 32);
            label12.TabIndex = 9;
            label12.Text = "ERROR RELATIVO:";
            // 
            // FormularioSecante
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(975, 548);
            Controls.Add(LabelTitulo);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            ForeColor = SystemColors.ControlText;
            Name = "FormularioSecante";
            Text = "FormularioSecante";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTitulo;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox TextBoxFuncion;
        private Button BtnVerFuncion;
        private Button BtnCalcularRaiz;
        private Label label6;
        private TextBox TextBoxIteraciones;
        private TextBox TextBoxXi;
        private Label label7;
        private Label label4;
        private TextBox TextBoxTolerancia;
        private GroupBox groupBox2;
        private Label label11;
        private TextBox TextBoxObservaciones;
        private Label label9;
        private TextBox TextBoxXrResult;
        private TextBox TextBoxErrorRelativoResult;
        private TextBox TextBoxIteracionesResult;
        private TextBox TextBoxConvergenciaResult;
        private Label label1;
        private Label label10;
        private Label label12;
        private TextBox TextBoxXd;
        private Label label8;
    }
}