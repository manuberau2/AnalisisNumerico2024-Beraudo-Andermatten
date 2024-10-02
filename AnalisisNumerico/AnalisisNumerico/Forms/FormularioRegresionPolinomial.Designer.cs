namespace AnalisisNumerico.Forms
{
    partial class FormularioRegresionPolinomial
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
            groupBox2 = new GroupBox();
            PanelGraficador = new Panel();
            TextBoxAjuste = new TextBox();
            TextBoxCorrelacion = new TextBox();
            TextBoxFuncionObtenida = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            TextBoxGrado = new TextBox();
            label10 = new Label();
            label5 = new Label();
            BtnCalcular = new Button();
            BtnBorrarTodos = new Button();
            BtnBorrarUltimo = new Button();
            BtnCargarPunto = new Button();
            label6 = new Label();
            PanelPuntosIngresados = new Panel();
            TextBoxTolerancia = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TextBoxPuntoY = new TextBox();
            TextBoxPuntoX = new TextBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PanelGraficador);
            groupBox2.Controls.Add(TextBoxAjuste);
            groupBox2.Controls.Add(TextBoxCorrelacion);
            groupBox2.Controls.Add(TextBoxFuncionObtenida);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.ForeColor = Color.FromArgb(223, 225, 210);
            groupBox2.Location = new Point(490, 12);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(468, 524);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Salida";
            // 
            // PanelGraficador
            // 
            PanelGraficador.BackColor = Color.Silver;
            PanelGraficador.Location = new Point(19, 178);
            PanelGraficador.Margin = new Padding(2);
            PanelGraficador.Name = "PanelGraficador";
            PanelGraficador.Size = new Size(439, 336);
            PanelGraficador.TabIndex = 7;
            // 
            // TextBoxAjuste
            // 
            TextBoxAjuste.Location = new Point(264, 128);
            TextBoxAjuste.Margin = new Padding(2);
            TextBoxAjuste.Name = "TextBoxAjuste";
            TextBoxAjuste.ReadOnly = true;
            TextBoxAjuste.Size = new Size(173, 31);
            TextBoxAjuste.TabIndex = 6;
            // 
            // TextBoxCorrelacion
            // 
            TextBoxCorrelacion.Location = new Point(264, 85);
            TextBoxCorrelacion.Margin = new Padding(2);
            TextBoxCorrelacion.Name = "TextBoxCorrelacion";
            TextBoxCorrelacion.ReadOnly = true;
            TextBoxCorrelacion.Size = new Size(173, 31);
            TextBoxCorrelacion.TabIndex = 5;
            // 
            // TextBoxFuncionObtenida
            // 
            TextBoxFuncionObtenida.Location = new Point(264, 42);
            TextBoxFuncionObtenida.Margin = new Padding(2);
            TextBoxFuncionObtenida.Name = "TextBoxFuncionObtenida";
            TextBoxFuncionObtenida.ReadOnly = true;
            TextBoxFuncionObtenida.Size = new Size(173, 31);
            TextBoxFuncionObtenida.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(17, 125);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(229, 30);
            label9.TabIndex = 3;
            label9.Text = "Efectividad del ajuste:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(17, 85);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(160, 30);
            label8.TabIndex = 2;
            label8.Text = "Correlación (r):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(17, 41);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(192, 30);
            label7.TabIndex = 1;
            label7.Text = "Función obtenida:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TextBoxGrado);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(BtnCalcular);
            groupBox1.Controls.Add(BtnBorrarTodos);
            groupBox1.Controls.Add(BtnBorrarUltimo);
            groupBox1.Controls.Add(BtnCargarPunto);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(PanelPuntosIngresados);
            groupBox1.Controls.Add(TextBoxTolerancia);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TextBoxPuntoY);
            groupBox1.Controls.Add(TextBoxPuntoX);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.FromArgb(223, 225, 210);
            groupBox1.Location = new Point(16, 12);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(468, 524);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entrada";
            // 
            // TextBoxGrado
            // 
            TextBoxGrado.Location = new Point(258, 166);
            TextBoxGrado.Margin = new Padding(2);
            TextBoxGrado.Name = "TextBoxGrado";
            TextBoxGrado.Size = new Size(145, 31);
            TextBoxGrado.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(24, 166);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(162, 30);
            label10.TabIndex = 16;
            label10.Text = "Ingresar grado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(407, 113);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(31, 30);
            label5.TabIndex = 15;
            label5.Text = "%";
            // 
            // BtnCalcular
            // 
            BtnCalcular.ForeColor = Color.Black;
            BtnCalcular.Location = new Point(268, 476);
            BtnCalcular.Margin = new Padding(2);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(178, 38);
            BtnCalcular.TabIndex = 14;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += BtnCalcular_Click;
            // 
            // BtnBorrarTodos
            // 
            BtnBorrarTodos.ForeColor = Color.Black;
            BtnBorrarTodos.Location = new Point(268, 385);
            BtnBorrarTodos.Margin = new Padding(2);
            BtnBorrarTodos.Name = "BtnBorrarTodos";
            BtnBorrarTodos.Size = new Size(178, 38);
            BtnBorrarTodos.TabIndex = 13;
            BtnBorrarTodos.Text = "Borrar todos";
            BtnBorrarTodos.UseVisualStyleBackColor = true;
            BtnBorrarTodos.Click += BtnBorrarTodos_Click;
            // 
            // BtnBorrarUltimo
            // 
            BtnBorrarUltimo.ForeColor = Color.Black;
            BtnBorrarUltimo.Location = new Point(268, 343);
            BtnBorrarUltimo.Margin = new Padding(2);
            BtnBorrarUltimo.Name = "BtnBorrarUltimo";
            BtnBorrarUltimo.Size = new Size(178, 38);
            BtnBorrarUltimo.TabIndex = 12;
            BtnBorrarUltimo.Text = "Borrar último";
            BtnBorrarUltimo.UseVisualStyleBackColor = true;
            BtnBorrarUltimo.Click += BtnBorrarUltimo_Click;
            // 
            // BtnCargarPunto
            // 
            BtnCargarPunto.ForeColor = Color.Black;
            BtnCargarPunto.Location = new Point(268, 246);
            BtnCargarPunto.Margin = new Padding(2);
            BtnCargarPunto.Name = "BtnCargarPunto";
            BtnCargarPunto.Size = new Size(178, 38);
            BtnCargarPunto.TabIndex = 11;
            BtnCargarPunto.Text = "Cargar punto";
            BtnCargarPunto.UseVisualStyleBackColor = true;
            BtnCargarPunto.Click += BtnCargarPunto_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(25, 211);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(206, 30);
            label6.TabIndex = 10;
            label6.Text = "Puntos ingresados: ";
            // 
            // PanelPuntosIngresados
            // 
            PanelPuntosIngresados.AutoScroll = true;
            PanelPuntosIngresados.BackColor = Color.Silver;
            PanelPuntosIngresados.Location = new Point(25, 246);
            PanelPuntosIngresados.Margin = new Padding(2);
            PanelPuntosIngresados.Name = "PanelPuntosIngresados";
            PanelPuntosIngresados.Size = new Size(219, 273);
            PanelPuntosIngresados.TabIndex = 9;
            // 
            // TextBoxTolerancia
            // 
            TextBoxTolerancia.Location = new Point(259, 115);
            TextBoxTolerancia.Margin = new Padding(2);
            TextBoxTolerancia.Name = "TextBoxTolerancia";
            TextBoxTolerancia.Size = new Size(145, 31);
            TextBoxTolerancia.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 113);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(202, 30);
            label4.TabIndex = 5;
            label4.Text = "Ingresar tolerancia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(377, 18);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(26, 30);
            label3.TabIndex = 4;
            label3.Text = "Y";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(258, 18);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(27, 30);
            label2.TabIndex = 3;
            label2.Text = "X";
            // 
            // TextBoxPuntoY
            // 
            TextBoxPuntoY.Location = new Point(352, 52);
            TextBoxPuntoY.Margin = new Padding(2);
            TextBoxPuntoY.Name = "TextBoxPuntoY";
            TextBoxPuntoY.Size = new Size(72, 31);
            TextBoxPuntoY.TabIndex = 2;
            // 
            // TextBoxPuntoX
            // 
            TextBoxPuntoX.Location = new Point(239, 52);
            TextBoxPuntoX.Margin = new Padding(2);
            TextBoxPuntoX.Name = "TextBoxPuntoX";
            TextBoxPuntoX.Size = new Size(72, 31);
            TextBoxPuntoX.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(25, 51);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(164, 30);
            label1.TabIndex = 0;
            label1.Text = "Ingresar punto:";
            // 
            // FormularioRegresionPolinomial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(975, 548);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormularioRegresionPolinomial";
            Text = "FormularioRegresionPolinomial";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Panel PanelGraficador;
        private TextBox TextBoxAjuste;
        private TextBox TextBoxCorrelacion;
        private TextBox TextBoxFuncionObtenida;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox1;
        private TextBox TextBoxGrado;
        private Label label10;
        private Label label5;
        private Button BtnCalcular;
        private Button BtnBorrarTodos;
        private Button BtnBorrarUltimo;
        private Button BtnCargarPunto;
        private Label label6;
        private Panel PanelPuntosIngresados;
        private TextBox TextBoxTolerancia;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TextBoxPuntoY;
        private TextBox TextBoxPuntoX;
        private Label label1;
    }
}