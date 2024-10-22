namespace AnalisisNumerico.Forms
{
    partial class FormularioTrapecioSimple
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
            groupBox2 = new GroupBox();
            label11 = new Label();
            TextBoxObservacionesArea = new TextBox();
            TextBoxResultadoArea = new TextBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            TextBoxFuncionArea = new TextBox();
            BtnCalcularArea = new Button();
            TextBoxXdArea = new TextBox();
            label8 = new Label();
            TextBoxXiArea = new TextBox();
            label7 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(90, 22);
            label1.Name = "label1";
            label1.Size = new Size(295, 45);
            label1.TabIndex = 0;
            label1.Text = "TRAPECIO SIMPLE";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(TextBoxObservacionesArea);
            groupBox2.Controls.Add(TextBoxResultadoArea);
            groupBox2.Controls.Add(label2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.FromArgb(223, 225, 210);
            groupBox2.Location = new Point(498, 69);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(416, 467);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Salida";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(223, 225, 210);
            label11.Location = new Point(124, 213);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(206, 32);
            label11.TabIndex = 22;
            label11.Text = "OBSERVACIONES:";
            // 
            // TextBoxObservacionesArea
            // 
            TextBoxObservacionesArea.Location = new Point(52, 252);
            TextBoxObservacionesArea.Margin = new Padding(2);
            TextBoxObservacionesArea.Multiline = true;
            TextBoxObservacionesArea.Name = "TextBoxObservacionesArea";
            TextBoxObservacionesArea.ReadOnly = true;
            TextBoxObservacionesArea.ScrollBars = ScrollBars.Vertical;
            TextBoxObservacionesArea.Size = new Size(343, 142);
            TextBoxObservacionesArea.TabIndex = 21;
            // 
            // TextBoxResultadoArea
            // 
            TextBoxResultadoArea.Location = new Point(52, 134);
            TextBoxResultadoArea.Margin = new Padding(2);
            TextBoxResultadoArea.Name = "TextBoxResultadoArea";
            TextBoxResultadoArea.ReadOnly = true;
            TextBoxResultadoArea.Size = new Size(333, 39);
            TextBoxResultadoArea.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(223, 225, 210);
            label2.Location = new Point(106, 82);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(224, 32);
            label2.TabIndex = 5;
            label2.Text = "ÁREA RESULTANTE:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TextBoxFuncionArea);
            groupBox1.Controls.Add(BtnCalcularArea);
            groupBox1.Controls.Add(TextBoxXdArea);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(TextBoxXiArea);
            groupBox1.Controls.Add(label7);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.FromArgb(223, 225, 210);
            groupBox1.Location = new Point(60, 69);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(416, 468);
            groupBox1.TabIndex = 19;
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
            // TextBoxFuncionArea
            // 
            TextBoxFuncionArea.Location = new Point(44, 60);
            TextBoxFuncionArea.Margin = new Padding(2);
            TextBoxFuncionArea.Name = "TextBoxFuncionArea";
            TextBoxFuncionArea.Size = new Size(333, 39);
            TextBoxFuncionArea.TabIndex = 2;
            TextBoxFuncionArea.Validating += TextBoxFuncionArea_Validating;
            // 
            // BtnCalcularArea
            // 
            BtnCalcularArea.ForeColor = SystemColors.ControlText;
            BtnCalcularArea.Location = new Point(45, 325);
            BtnCalcularArea.Margin = new Padding(2);
            BtnCalcularArea.Name = "BtnCalcularArea";
            BtnCalcularArea.Size = new Size(332, 49);
            BtnCalcularArea.TabIndex = 11;
            BtnCalcularArea.Text = "Calcular área";
            BtnCalcularArea.UseVisualStyleBackColor = true;
            BtnCalcularArea.Click += BtnCalcularArea_Click;
            // 
            // TextBoxXdArea
            // 
            TextBoxXdArea.Location = new Point(217, 213);
            TextBoxXdArea.Margin = new Padding(2);
            TextBoxXdArea.Name = "TextBoxXdArea";
            TextBoxXdArea.Size = new Size(160, 39);
            TextBoxXdArea.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(223, 225, 210);
            label8.Location = new Point(276, 157);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(49, 32);
            label8.TabIndex = 15;
            label8.Text = "Xd:";
            // 
            // TextBoxXiArea
            // 
            TextBoxXiArea.Location = new Point(44, 213);
            TextBoxXiArea.Margin = new Padding(2);
            TextBoxXiArea.Name = "TextBoxXiArea";
            TextBoxXiArea.Size = new Size(160, 39);
            TextBoxXiArea.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(223, 225, 210);
            label7.Location = new Point(107, 166);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(41, 32);
            label7.TabIndex = 13;
            label7.Text = "Xi:";
            // 
            // FormularioTrapecioSimple
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(975, 548);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FormularioTrapecioSimple";
            Text = "FormularioTrapecioSimple";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox TextBoxXdArea;
        private TextBox TextBoxObservacionesArea;
        private TextBox TextBoxResultadoArea;
        private TextBox TextBoxFuncionArea;
        private Button BtnCalcularArea;
        private Label label1;
        private GroupBox groupBox2;
        private Label label11;
        private TextBox TextBoxObservaciones;
        private Label label9;
        private TextBox TextBoxXrResult;
        private TextBox TextBoxErrorRelativoResult;
        private TextBox TextBoxIteracionesResult;
        private TextBox TextBoxConvergenciaResult;
        private Label label2;
        private Label label10;
        private Label label12;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox TextBoxFuncion;
        private Button BtnVerFuncion;
        private Button BtnCalcularRaiz;
        private TextBox TextBoxXd;
        private Label label8;
        private TextBox TextBoxXiArea;
        private Label label7;
    }
}