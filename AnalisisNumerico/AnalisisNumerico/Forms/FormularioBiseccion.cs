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
using Calculus;

namespace AnalisisNumerico.Forms
{
    public partial class FormularioBiseccion : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        public FormularioBiseccion()
        {
            InitializeComponent();
        }

        private void TextBoxFuncion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxFuncion.Text))
            {
                errorProvider.SetError(TextBoxFuncion, "Ingrese una función");
                e.Cancel = true;
            }
            else
            {
                Calculo calculo = new Calculo();
                if (!calculo.Sintaxis(TextBoxFuncion.Text, 'x'))
                {
                    errorProvider.SetError(TextBoxFuncion, "La función no es válida");
                    e.Cancel = true;
                }
                else
                {
                    errorProvider.SetError(TextBoxFuncion, string.Empty);
                }
            }
        }

        private void TextBoxIteraciones_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxIteraciones.Text))
            {
                errorProvider.SetError(TextBoxIteraciones, "Ingrese un número de iteraciones");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(TextBoxIteraciones, string.Empty);
            }
        }

        private void TextBoxIteraciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxTolerancia_Validating(object sender, CancelEventArgs e)
        {
            // Verificar si el campo está vacío
            if (string.IsNullOrEmpty(TextBoxTolerancia.Text))
            {
                errorProvider.SetError(TextBoxTolerancia, "Ingrese una tolerancia");
                e.Cancel = true;
            }
            else
            {
                // Intentar convertir el texto a un número decimal
                if (decimal.TryParse(TextBoxTolerancia.Text, out decimal number))
                {
                    // Verificar si el número es mayor a 1
                    if (number > 1)
                    {
                        errorProvider.SetError(TextBoxTolerancia, "La tolerancia no debe ser mayor a 1");
                        e.Cancel = true;
                    }
                    else
                    {
                        errorProvider.SetError(TextBoxTolerancia, string.Empty);
                    }
                }
                else
                {
                    errorProvider.SetError(TextBoxTolerancia, "Ingrese un número decimal válido.");
                    e.Cancel = true;
                }
            }
        }

        private void TextBoxTolerancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, el punto decimal y teclas de control
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }
    }
}
