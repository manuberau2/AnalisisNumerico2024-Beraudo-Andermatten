using OxyPlot.Series;
using OxyPlot;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;
using NCalc.Domain;
using System.Security.Policy;

namespace AnalisisNumerico.Forms
{
    public partial class FormularioGrafica : Form
    {
        public FormularioGrafica(string funcion)
        {
            InitializeComponent();
            GraficarFuncion(funcion);
        }
        private void GraficarFuncion(string funcion)
        {
            string url = $"https://www.wolframalpha.com/input/?i=plot+{Uri.EscapeDataString(funcion)}";
            WebViewGeogebra.Source = new Uri(url);
        }
    }
}
