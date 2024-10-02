using Analisis_Numerico;
using AnalisisNumerico.Metodos.Unidad_3;
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
        public Graficador Graficador { get; set; }

        public FormularioRegresionLineal()
        {
            InitializeComponent();
            SetPanelGrafica();
        }

        private void SetPanelGrafica()
        {
            PanelGraficador.Controls.Clear();
            this.Graficador = new Graficador();
            PanelGraficador.Controls.Add(Graficador);
            Graficador.Dock = DockStyle.Fill;
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
            puntoIngresado.Text = $"({TextBoxPuntoX.Text}; {TextBoxPuntoY.Text})";
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

        private void BtnCalcularRegresionLineal_Click(object sender, EventArgs e)
        {
            if (PuntosCargados.Count < 2)
            {
                MessageBox.Show("Debe ingresar al menos dos puntos para calcular la regresión lineal.");
                return;
            }
            double tolerancia = 0;
            var (funcion, r, efectividad) = RegresionLineal.CalcularRegresionLineal(PuntosCargados, tolerancia);
            SetPanelGrafica();
            Graficador.Graficar(PuntosCargados, funcion);
            TextBoxFuncionObtenida.Text = funcion;
            TextBoxCorrelacion.Text = r.ToString();
            TextBoxAjuste.Text = efectividad;
            return;
        }

        private void BtnBorrarUltimo_Click(object sender, EventArgs e)
        {
            if (PuntosCargados.Count == 0)
            {
                MessageBox.Show("No hay puntos para borrar.");
                return;
            }
            PuntosCargados.RemoveAt(PuntosCargados.Count - 1);
            PanelPuntosIngresados.Controls.RemoveAt(PanelPuntosIngresados.Controls.Count - 1);
            PanelPuntosIngresados.Show();
            return;
        }

        private void BtnBorrarTodos_Click(object sender, EventArgs e)
        {
            PuntosCargados.RemoveAll(punto => true);
            PanelPuntosIngresados.Controls.Clear();
            PanelPuntosIngresados.Show();
            return;
        }
    }
}