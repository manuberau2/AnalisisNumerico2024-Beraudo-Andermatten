using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Metodos.Unidad_2
{
    public class Gauss_Seidel
    {
        public ResultadoUnidad2 GaussSeidel(double[,] matrizinicio, double tolerancia, int nroiteraciones)
        {
            ResultadoUnidad2 res = new ResultadoUnidad2();
            int n = matrizinicio.GetLength(0); // Número de filas (y columnas de A)
            double[] x = new double[n];
            double[] xOld = new double[n];

            for (int i = 0; i < nroiteraciones; i++)
            {
                Array.Copy(x, xOld, n);  // Copiar x en xOld

                for (int k = 0; k < n; k++)
                {
                    double sum = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (j != k)
                        {
                            sum += matrizinicio[k, j] * x[j];
                        }
                    }
                    x[k] = (matrizinicio[k, n] - sum) / matrizinicio[k, k];
                }

                // Verificar la convergencia
                double maxError = 0;
                for (int j = 0; j < n; j++)
                {
                    maxError = Math.Max(maxError, Math.Abs(x[i] - xOld[i]));
                }

                if (maxError < tolerancia)
                {
                    Console.WriteLine($"Convergencia alcanzada en {i + 1} iteraciones.");
                    break;
                }
            }

            // Convertir la matriz en la matriz identidad y colocar los resultados en la última columna
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrizinicio[i, j] = (i == j) ? 1.0 : 0.0;
                }
                matrizinicio[i, n] = x[i];
            }
            return res;
        }
    }
}