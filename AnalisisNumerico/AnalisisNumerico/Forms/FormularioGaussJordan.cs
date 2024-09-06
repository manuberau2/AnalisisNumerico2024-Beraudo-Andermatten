using AnalisisNumerico.Metodos.Unidad_2;
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
    public partial class FormularioGaussJordan : Form
    {
        public FormularioGaussJordan()
        {
            InitializeComponent();
        }

        private void BtnGenerarMatriz_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TextBoxDimensionMatriz.Text, out int dimension))
            {
                MessageBox.Show("Indique la dimensión de la matriz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dimension > 10)
            {
                MessageBox.Show("La dimensión debe ser menor a 10.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dimension = int.Parse(TextBoxDimensionMatriz.Text);
                int puntoX = 30;
                int puntoY = 60;

                GroupBoxMatriz.Controls.Clear();  // Limpiar controles anteriores

                // Ajuste de la posición de los Labels (x1, x2, ..., xn y Término independiente)
                for (int col = 0; col < dimension + 1; col++)
                {
                    Label label = new Label();
                    if (col == dimension)
                    {
                        label.Text = "TI";  // Etiqueta para la última columna
                    }
                    else
                    {
                        label.Text = $"x{col + 1}";  // Etiquetas x1, x2, ..., xn
                    }

                    label.Location = new Point(puntoX, puntoY - 30);  // Posicionar arriba de los TextBox
                    label.AutoSize = true;  // Ajustar el tamaño automáticamente al texto
                    label.Size = new Size(80, 20);  // Aumentar tamaño para evitar que se corte el texto
                    GroupBoxMatriz.Controls.Add(label);
                    puntoX += 85;  // Aumentar el espacio horizontal para que no se solapen
                }

                // Reiniciar puntoX y ajustar puntoY para los TextBox
                puntoX = 30;
                puntoY = 60;

                // Crear TextBoxes para la matriz
                for (int row = 0; row < dimension; row++)
                {
                    for (int col = 0; col < dimension + 1; col++)
                    {
                        string nombre = $"({row},{col})";

                        TextBox textBox = new TextBox();
                        textBox.Name = nombre;
                        ToolTip toolTip = new ToolTip();
                        toolTip.SetToolTip(textBox, nombre);
                        textBox.Location = new Point(puntoX, puntoY);
                        textBox.Size = new Size(75, 30);

                        // Cambiar el color de fondo de la última columna (término independiente)
                        if (col == dimension)
                        {
                            textBox.BackColor = Color.LightBlue;
                        }

                        GroupBoxMatriz.Controls.Add(textBox);
                        puntoX += 85;  // Aumentar el espacio horizontal entre los TextBoxes
                    }

                    // Reiniciar puntoX y avanzar puntoY para la siguiente fila
                    puntoX = 30;
                    puntoY += 40;
                }

                GroupBoxMatriz.Show();
            }
        }

        private double[,] GuardarMatriz(int dimension)
        {
            double[,] matriz = new double[dimension, dimension + 1];
            for (int row = 0; row < dimension; row++)
            {
                for (int col = 0; col < dimension + 1; col++)
                {
                    string nombre = $"({row},{col})";
                    TextBox textBox = GroupBoxMatriz.Controls.Find(nombre, true).FirstOrDefault() as TextBox;
                    if (!double.TryParse(textBox.Text, out double valor))
                    {
                        MessageBox.Show("Ingrese un valor válido en la matriz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                    matriz[row, col] = valor;
                }
            }
            return matriz;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double[,] matriz = GuardarMatriz(int.Parse(TextBoxDimensionMatriz.Text));
            if (matriz == null)
            {
                return;
            }
            Gauss_Jordan gauss_Jordan = new Gauss_Jordan();
            ResultadoUnidad2 resultado = gauss_Jordan.GaussJordan(matriz);
        }
    }
}