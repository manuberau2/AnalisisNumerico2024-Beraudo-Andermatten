using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalisisNumerico.Forms
{
    public partial class FormularioRegresionLineal : Form
    {
        public FormularioRegresionLineal()
        {
            InitializeComponent();
        }

        public List<double[]> PuntosCargados { get; set; } = new List<double[]>();

        public void CargarPunto(double x, double y)
        {
            double[] punto = new double[2] { x, y };
            PuntosCargados.Add(punto);
        }

        private void BtnCargarPunto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxPuntoX.Text))
            {
                MessageBox.Show("Ingrese un valor para X");
                return;
            }
            if (string.IsNullOrEmpty(TextBoxPuntoY.Text))
            {
                MessageBox.Show("Ingrese un valor para Y");
                return;
            }

            CargarPunto(double.Parse(TextBoxPuntoX.Text), double.Parse(TextBoxPuntoY.Text));
            Label puntoIngresado = new Label();
            puntoIngresado.Text = $"({TextBoxPuntoX.Text}, {TextBoxPuntoY.Text})";
            int cantElementos = PuntosCargados.Count;
            int puntoY = (cantElementos - 1) * 30;
            puntoIngresado.Location = new Point(0, puntoY);
            puntoIngresado.Size = new Size(PanelPuntosIngresados.Width, 25);
            puntoIngresado.TextAlign = ContentAlignment.MiddleCenter;
            puntoIngresado.ForeColor = Color.Black;
            puntoIngresado.Font = new Font("Arial", 9);
            PanelPuntosIngresados.Controls.Add(puntoIngresado);
            PanelPuntosIngresados.Show();
            TextBoxPuntoX.Clear();
            TextBoxPuntoY.Clear();
        }
    }
}