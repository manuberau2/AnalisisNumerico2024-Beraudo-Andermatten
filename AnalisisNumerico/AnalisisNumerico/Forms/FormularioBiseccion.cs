using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalisisNumericos;
using AnalisisNumerico.Metodos.Unidad_1;

namespace AnalisisNumerico.Forms
{
    public partial class FormularioBiseccion : Form
    {
        public FormularioBiseccion()
        {
            InitializeComponent();
        }

        private void BtnCalcularRaiz_Click(object sender, EventArgs e)
        {
            MetodosCerrados metodoCerrado = new MetodosCerrados();
            Resultado resultado = new Resultado();
            string funcion = TextBoxFuncion.Text;
            double tolerancia = Convert.ToDouble(TextBoxTolerancia.Text);
            int iteraciones = Convert.ToInt32(TextBoxIteraciones.Text);
            resultado = metodoCerrado.UseBiseccion(funcion, tolerancia, iteraciones);
        }
    }
}
