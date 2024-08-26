using AnalisisNumerico.Metodos.Unidad_1;
using AnalisisNumericos;
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
    public partial class FormularioSecante : Form
    {
        ErrorProvider errorProvider = new ErrorProvider();
        public FormularioSecante()
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

        private void TextBoxXi_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Permitir solo dígitos, el punto decimal, el signo "-" y teclas de control
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == ',' && textBox.Text.Contains(","))
            {
                e.Handled = true;
            }

            // Permitir solo un signo "-" al inicio del texto
            if (e.KeyChar == '-' && (textBox.Text.Length > 0 || textBox.Text.Contains("-")))
            {
                e.Handled = true;
            }
        }

        private void TextBoxXd_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Permitir solo dígitos, el punto decimal, el signo "-" y teclas de control
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == ',' && textBox.Text.Contains(","))
            {
                e.Handled = true;
            }

            // Permitir solo un signo "-" al inicio del texto
            if (e.KeyChar == '-' && (textBox.Text.Length > 0 || textBox.Text.Contains("-")))
            {
                e.Handled = true;
            }
        }

        private void TextBoxIteraciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxTolerancia_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos, el punto decimal y teclas de control
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void BtnVerFuncion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxFuncion.Text))
            {
                MessageBox.Show("No ha ingresado una función.");
                return;
            }
            FormularioGrafica formularioGrafica = new FormularioGrafica(TextBoxFuncion.Text);
            formularioGrafica.Show();
        }

        private void BtnCalcularRaiz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TextBoxFuncion.Text) || string.IsNullOrWhiteSpace(TextBoxIteraciones.Text) || string.IsNullOrWhiteSpace(TextBoxTolerancia.Text) || string.IsNullOrWhiteSpace(TextBoxXi.Text) || string.IsNullOrWhiteSpace(TextBoxXd.Text))
            {
                MessageBox.Show("Debe completar todos los campos");
                return;
            }
            MetodosAbiertos metodosAbiertos = new MetodosAbiertos();
            Resultado resultado = metodosAbiertos.UseSecante(TextBoxFuncion.Text, double.Parse(TextBoxTolerancia.Text), int.Parse(TextBoxIteraciones.Text), double.Parse(TextBoxXi.Text), double.Parse(TextBoxXd.Text));
            if (!resultado.Sucess)
            {
                TextBoxConvergenciaResult.Text = "No";
                TextBoxXrResult.Text = "No se encontró la raíz";
                TextBoxErrorRelativoResult.Text = "-";
                TextBoxIteracionesResult.Text = resultado.CantidadIteraciones.ToString();
                TextBoxObservaciones.Text = "No fue posible encontrar la raíz";
                return;
            }
            TextBoxConvergenciaResult.Text = resultado.Converge ? "Sí" : "No";
            TextBoxXrResult.Text = Math.Round(resultado.ValorXr, 4).ToString();
            TextBoxErrorRelativoResult.Text = Math.Round(resultado.ErrorRelativo, 4).ToString();
            TextBoxIteracionesResult.Text = resultado.CantidadIteraciones.ToString();

            TextBoxObservaciones.Text = resultado.Converge
                ? "Felicitaciones, el método converge y se ha encontrado la raíz en el intervalo proporcionado."
                : "El método llegó a la cantidad de iteraciones y no encontró la raíz exacta.";

        }

    }
}
