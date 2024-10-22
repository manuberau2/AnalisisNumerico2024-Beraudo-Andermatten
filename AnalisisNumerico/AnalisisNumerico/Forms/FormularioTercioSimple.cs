using AnalisisNumerico.Metodos.Unidad_4;
using Calculus;
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
    public partial class FormularioTercioSimple : Form
    {
        public FormularioTercioSimple()
        {
            InitializeComponent();
        }

        private void BtnCalcularArea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxFuncionArea.Text))
            {
                MessageBox.Show("Ingrese una función", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(TextBoxXiArea.Text))
            {
                MessageBox.Show("Ingrese el valor de xi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(TextBoxXdArea.Text))
            {
                MessageBox.Show("Ingrese el valor de xd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double xi = double.Parse(TextBoxXiArea.Text);
            double xd = double.Parse(TextBoxXdArea.Text);
            string funcion = TextBoxFuncionArea.Text;

            IntegralSimpson integralSimpson = new IntegralSimpson();
            double areaResultante = integralSimpson.CalcularIntegralSimpson13Simple(funcion, xi, xd);

            if (double.IsNaN(areaResultante))
            {
                TextBoxResultadoArea.Text = "Error en el cálculo";
                TextBoxObservacionesArea.Text = "Hubo un error en el cálculo de la integral";
                return;
            }

            TextBoxResultadoArea.Text = areaResultante.ToString();
            TextBoxObservacionesArea.Text = "Felicidades, se ha podido calcular la integral exitosamente";
            return;
        }

        private void TextBoxFuncionArea_Validating(object sender, CancelEventArgs e)
        {
            Calculo calculo = new Calculo();
            if (calculo.Sintaxis(TextBoxFuncionArea.Text, 'x'))
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("La función ingresada no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}