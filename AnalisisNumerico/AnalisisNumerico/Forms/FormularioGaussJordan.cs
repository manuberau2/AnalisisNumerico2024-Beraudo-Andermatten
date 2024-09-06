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
            // Obtener la dimensión de la matriz desde el TextBox
            int dimension = int.Parse(TextBoxDimensionMatriz.Text);

            // Guardar la matriz ingresada por el usuario
            double[,] matriz = GuardarMatriz(dimension);
            if (matriz == null)
            {
                return; // Si la matriz es inválida, no continuar
            }
            Gauss_Jordan gauss_jordan = new Gauss_Jordan();
            // Llamar al método Gauss-Jordan para obtener la matriz solución
            ResultadoUnidad2 resultado = gauss_jordan.GaussJordan(matriz);

            // Verificar si la operación fue exitosa
            if (resultado.Sucess)
            {
                // Actualizar los TextBox con la matriz resultado
                ActualizarTextBoxesConResultado(resultado.MatrizResultado, dimension);
            }
            else
            {
                // Mostrar el mensaje de error si la operación falla
                MessageBox.Show("Error en el cálculo: " + resultado.MensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarTextBoxesConResultado(double[,] matrizResultado, int dimension)
        {
            for (int row = 0; row < dimension; row++)
            {
                for (int col = 0; col < dimension + 1; col++)
                {
                    string nombre = $"({row},{col})";
                    TextBox textBox = GroupBoxMatriz.Controls.Find(nombre, true).FirstOrDefault() as TextBox;

                    if (textBox != null)
                    {
                        // Actualizar el valor del TextBox con el valor de la matriz resultado
                        textBox.Text = matrizResultado[row, col].ToString("F3"); // Formato de dos decimales
                    }
                }
            }
        }
    }
}