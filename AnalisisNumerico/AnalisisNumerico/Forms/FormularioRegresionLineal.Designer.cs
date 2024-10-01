namespace AnalisisNumerico.Forms
{
    partial class FormularioRegresionLineal
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
            groupBox1 = new GroupBox();
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
            groupBox2 = new GroupBox();
            PanelGraficador = new Panel();
            TextBoxAjuste = new TextBox();
            TextBoxCorrelacion = new TextBox();
            TextBoxFuncionObtenida = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(18, 10);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(374, 419);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Entrada";
            // 
            // BtnCalcular
            // 
            BtnCalcular.ForeColor = Color.Black;
            BtnCalcular.Location = new Point(214, 374);
            BtnCalcular.Margin = new Padding(2, 2, 2, 2);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(142, 30);
            BtnCalcular.TabIndex = 14;
            BtnCalcular.Text = "Calcular";
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += BtnCalcularRegresionLineal_Click;
            // 
            // BtnBorrarTodos
            // 
            BtnBorrarTodos.ForeColor = Color.Black;
            BtnBorrarTodos.Location = new Point(214, 298);
            BtnBorrarTodos.Margin = new Padding(2, 2, 2, 2);
            BtnBorrarTodos.Name = "BtnBorrarTodos";
            BtnBorrarTodos.Size = new Size(142, 30);
            BtnBorrarTodos.TabIndex = 13;
            BtnBorrarTodos.Text = "Borrar todos";
            BtnBorrarTodos.UseVisualStyleBackColor = true;
            // 
            // BtnBorrarUltimo
            // 
            BtnBorrarUltimo.ForeColor = Color.Black;
            BtnBorrarUltimo.Location = new Point(214, 254);
            BtnBorrarUltimo.Margin = new Padding(2, 2, 2, 2);
            BtnBorrarUltimo.Name = "BtnBorrarUltimo";
            BtnBorrarUltimo.Size = new Size(142, 30);
            BtnBorrarUltimo.TabIndex = 12;
            BtnBorrarUltimo.Text = "Borrar último";
            BtnBorrarUltimo.UseVisualStyleBackColor = true;
            // 
            // BtnCargarPunto
            // 
            BtnCargarPunto.ForeColor = Color.Black;
            BtnCargarPunto.Location = new Point(214, 161);
            BtnCargarPunto.Margin = new Padding(2, 2, 2, 2);
            BtnCargarPunto.Name = "BtnCargarPunto";
            BtnCargarPunto.Size = new Size(142, 30);
            BtnCargarPunto.TabIndex = 11;
            BtnCargarPunto.Text = "Cargar punto";
            BtnCargarPunto.UseVisualStyleBackColor = true;
            BtnCargarPunto.Click += BtnCargarPunto_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(20, 134);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(178, 25);
            label6.TabIndex = 10;
            label6.Text = "Puntos ingresados: ";
            // 
            // PanelPuntosIngresados
            // 
            PanelPuntosIngresados.AutoScroll = true;
            PanelPuntosIngresados.BackColor = Color.Silver;
            PanelPuntosIngresados.Location = new Point(20, 161);
            PanelPuntosIngresados.Margin = new Padding(2, 2, 2, 2);
            PanelPuntosIngresados.Name = "PanelPuntosIngresados";
            PanelPuntosIngresados.Size = new Size(175, 254);
            PanelPuntosIngresados.TabIndex = 9;
            // 
            // TextBoxTolerancia
            // 
            TextBoxTolerancia.Location = new Point(207, 92);
            TextBoxTolerancia.Margin = new Padding(2, 2, 2, 2);
            TextBoxTolerancia.Name = "TextBoxTolerancia";
            TextBoxTolerancia.Size = new Size(117, 27);
            TextBoxTolerancia.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(20, 91);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(177, 25);
            label4.TabIndex = 5;
            label4.Text = "Ingresar tolerancia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(302, 15);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(23, 25);
            label3.TabIndex = 4;
            label3.Text = "Y";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(207, 15);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(24, 25);
            label2.TabIndex = 3;
            label2.Text = "X";
            // 
            // TextBoxPuntoY
            // 
            TextBoxPuntoY.Location = new Point(282, 42);
            TextBoxPuntoY.Margin = new Padding(2, 2, 2, 2);
            TextBoxPuntoY.Name = "TextBoxPuntoY";
            TextBoxPuntoY.Size = new Size(58, 27);
            TextBoxPuntoY.TabIndex = 2;
            // 
            // TextBoxPuntoX
            // 
            TextBoxPuntoX.Location = new Point(191, 42);
            TextBoxPuntoX.Margin = new Padding(2, 2, 2, 2);
            TextBoxPuntoX.Name = "TextBoxPuntoX";
            TextBoxPuntoX.Size = new Size(58, 27);
            TextBoxPuntoX.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 25);
            label1.TabIndex = 0;
            label1.Text = "Ingresar punto:";
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
            groupBox2.Location = new Point(397, 10);
            groupBox2.Margin = new Padding(2, 2, 2, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 2, 2, 2);
            groupBox2.Size = new Size(374, 419);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Salida";
            // 
            // PanelGraficador
            // 
            PanelGraficador.BackColor = Color.Silver;
            PanelGraficador.Location = new Point(15, 142);
            PanelGraficador.Margin = new Padding(2, 2, 2, 2);
            PanelGraficador.Name = "PanelGraficador";
            PanelGraficador.Size = new Size(351, 269);
            PanelGraficador.TabIndex = 7;
            // 
            // TextBoxAjuste
            // 
            TextBoxAjuste.Location = new Point(211, 102);
            TextBoxAjuste.Margin = new Padding(2, 2, 2, 2);
            TextBoxAjuste.Name = "TextBoxAjuste";
            TextBoxAjuste.ReadOnly = true;
            TextBoxAjuste.Size = new Size(139, 27);
            TextBoxAjuste.TabIndex = 6;
            // 
            // TextBoxCorrelacion
            // 
            TextBoxCorrelacion.Location = new Point(211, 68);
            TextBoxCorrelacion.Margin = new Padding(2, 2, 2, 2);
            TextBoxCorrelacion.Name = "TextBoxCorrelacion";
            TextBoxCorrelacion.ReadOnly = true;
            TextBoxCorrelacion.Size = new Size(139, 27);
            TextBoxCorrelacion.TabIndex = 5;
            // 
            // TextBoxFuncionObtenida
            // 
            TextBoxFuncionObtenida.Location = new Point(211, 34);
            TextBoxFuncionObtenida.Margin = new Padding(2, 2, 2, 2);
            TextBoxFuncionObtenida.Name = "TextBoxFuncionObtenida";
            TextBoxFuncionObtenida.ReadOnly = true;
            TextBoxFuncionObtenida.Size = new Size(139, 27);
            TextBoxFuncionObtenida.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(14, 101);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(199, 25);
            label9.TabIndex = 3;
            label9.Text = "Efectividad del ajuste:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(14, 69);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(139, 25);
            label8.TabIndex = 2;
            label8.Text = "Correlación (r):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 34);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(166, 25);
            label7.TabIndex = 1;
            label7.Text = "Función obtenida:";
            // 
            // FormularioRegresionLineal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 30, 45);
            ClientSize = new Size(780, 438);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormularioRegresionLineal";
            Text = "FormularioRegresionLineal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox TextBoxTolerancia;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox TextBoxPuntoY;
        private TextBox TextBoxPuntoX;
        private Button BtnCargarPunto;
        private Label label6;
        private Panel PanelPuntosIngresados;
        private Button BtnCalcular;
        private Button BtnBorrarTodos;
        private Button BtnBorrarUltimo;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox TextBoxAjuste;
        private TextBox TextBoxCorrelacion;
        private TextBox TextBoxFuncionObtenida;
        private Panel PanelGraficador;
    }
}