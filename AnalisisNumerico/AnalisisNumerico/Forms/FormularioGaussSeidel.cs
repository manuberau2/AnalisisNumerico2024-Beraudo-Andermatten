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
    public partial class FormularioGaussSeidel : Form
    {
        public FormularioGaussSeidel()
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

        private double[,]? GuardarMatriz(int dimension)
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
            if (!int.TryParse(TextBoxDimensionMatriz.Text, out int dimension))
            {
                MessageBox.Show("Indique la dimensión de la matriz", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Guardar la matriz ingresada por el usuario
            double[,] matriz = GuardarMatriz(dimension);
            if (matriz == null)
            {
                return; // Si la matriz es inválida, no continuar
            }

            // Obtener los valores de tolerancia y número máximo de iteraciones
            if (!double.TryParse(TextBoxTolerancia.Text, out double tolerancia))
            {
                MessageBox.Show("Ingrese un valor válido para la tolerancia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(TextBoxIteraciones.Text, out int maxIteraciones))
            {
                MessageBox.Show("Ingrese un valor válido para el número máximo de iteraciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Gauss_Seidel gauss_Seidel = new Gauss_Seidel();

            // Llamar al método de Gauss-Seidel para resolver el sistema
            ResultadoUnidad2 resultado = gauss_Seidel.UseMethod(matriz, tolerancia, maxIteraciones);

            if (resultado.Sucess)
            {
                // Limpiar los controles anteriores en el GroupBoxResultado
                GroupBoxResultado.Controls.Clear();

                // Ajustes de posicionamiento
                int posXLabel = 20;   // Posición horizontal de los Label
                int posXTextBox = 80; // Posición horizontal de los TextBox
                int posYInicial = 40; // Posición vertical inicial (más abajo)
                int separacionVertical = 40; // Espacio entre cada fila

                // Mostrar las soluciones en el GroupBox de forma vertical
                for (int i = 0; i < dimension; i++)
                {
                    // Crear un Label para mostrar "x1 =", "x2 =", etc.
                    Label label = new Label();
                    label.Text = $"x{i + 1} =";
                    label.Location = new Point(posXLabel, posYInicial + separacionVertical * i); // Posición dinámica
                    label.AutoSize = true;
                    label.Font = new Font(label.Font.FontFamily, 10); // Fuente más pequeña

                    // Crear un TextBox para mostrar la solución de x1, x2, etc.
                    TextBox textBox = new TextBox();
                    textBox.Name = $"ResultadoX{i + 1}";
                    // Aplicar formato condicional: sin decimales si el número es entero, con 2 decimales si no
                    double resultadoX = resultado.VectorResultante[i];
                    textBox.Text = (resultadoX % 1 == 0) ? resultadoX.ToString("F0") : resultadoX.ToString("F2");

                    textBox.Location = new Point(posXTextBox, posYInicial + separacionVertical * i); // Más a la derecha
                    textBox.Width = 100;
                    textBox.BackColor = Color.LightGreen;
                    textBox.ReadOnly = true; // Solo lectura

                    // Agregar el Label y TextBox al GroupBox
                    GroupBoxResultado.Controls.Add(label);
                    GroupBoxResultado.Controls.Add(textBox);
                }
                // Posición para el siguiente Label y TextBox (cantidad de iteraciones)
                int posYIteraciones = posYInicial + separacionVertical * dimension + 20; // Ajustar la posición más abajo

                // Crear el Label "Cantidad de iteraciones:"
                Label labelIteraciones = new Label();
                labelIteraciones.Text = "Cantidad de iteraciones:";
                labelIteraciones.Location = new Point(posXLabel, posYIteraciones);
                labelIteraciones.AutoSize = true;
                labelIteraciones.Font = new Font(labelIteraciones.Font.FontFamily, 10);

                // Crear un TextBox para mostrar la cantidad de iteraciones
                TextBox textBoxIteraciones = new TextBox();
                textBoxIteraciones.Name = "ResultadoIteraciones";
                textBoxIteraciones.Text = resultado.CantidadIteraciones.ToString(); // Mostrar la cantidad de iteraciones
                textBoxIteraciones.Location = new Point(posXTextBox, posYIteraciones + 20); // Debajo del Label
                textBoxIteraciones.Width = 100;
                textBoxIteraciones.ReadOnly = true; // Solo lectura

                // Agregar el Label y TextBox al GroupBox
                GroupBoxResultado.Controls.Add(labelIteraciones);
                GroupBoxResultado.Controls.Add(textBoxIteraciones);
            }
            else
            {
                MessageBox.Show($"Error: {resultado.MensajeError}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}