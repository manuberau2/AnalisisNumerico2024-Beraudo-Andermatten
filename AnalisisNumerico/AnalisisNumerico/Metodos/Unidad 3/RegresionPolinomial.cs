using AnalisisNumerico.Metodos.Unidad_2;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace AnalisisNumerico.Metodos.Unidad_3
{
    public class RegresionPolinomial
    {
        public static (double[,], string, double) GenerarMatrizPolinomial(int grado, List<double[]> puntosCargados, double tolerancia)
        {
            int dimension = grado + 1;
            double[,] matriz = new double[dimension, dimension + 1];
            double x = 0, y = 0;

            foreach (var punto in puntosCargados)
            {
                x = punto[0];
                y = punto[1];

                for (int fila = 0; fila < dimension; fila++)
                {
                    for (int col = 0; col < dimension; col++)
                    {
                        matriz[fila, col] = Math.Pow(x, fila + col);

                        if (Math.Abs(matriz[fila, col]) < tolerancia)
                        {
                            matriz[fila, col] = 0;
                        }

                        matriz[fila, col] += matriz[fila, col];
                    }

                    double terminoIndependiente = y * Math.Pow(x, fila);

                    if (Math.Abs(terminoIndependiente) < tolerancia)
                    {
                        terminoIndependiente = 0;
                    }

                    matriz[fila, dimension] += terminoIndependiente;
                }
            }
            Gauss_Jordan g = new Gauss_Jordan();
            ResultadoUnidad2 ResultadoGJ = g.UseMethod(matriz);

            // 4. Construimos la función polinómica como un string
            string funcion = string.Empty;
            for (int i = 0; i < ResultadoGJ.VectorResultante.Count(); i++)
            {
                double ai = Math.Round(ResultadoGJ.VectorResultante[i], 4); // Redondeamos los coeficientes a 4 decimales
                string termino = (i == 0) ? $"{ai}" : (ai != 0 ? $"{(ai > 0 ? "+" : "")}{ai}x^{i}" : "");
                funcion = termino + funcion; // Construimos la función, con el coeficiente correspondiente a x^i
            }

            // 5. Calcular el coeficiente de correlación r
            double SumY = 0;
            double sr = 0; // Error cuadrático residual (sum of residual squares)
            double st = 0; // Error cuadrático total (sum of total squares)

            // Calculamos la sumatoria de Y
            foreach (var punto in puntosCargados)
            {
                SumY += punto[1]; // Sumar todas las Y
            }

            // Promedio de Y
            double promedioY = SumY / puntosCargados.Count;

            // Recorremos los puntos para calcular sr y st
            foreach (var punto in puntosCargados)
            {
                x = punto[0];
                y = punto[1];

                // Calculamos el valor predicho usando el polinomio
                double yPredicho = 0;
                for (int i = 0; i < ResultadoGJ.VectorResultante.Count(); i++)
                {
                    yPredicho += ResultadoGJ.VectorResultante[i] * Math.Pow(x, i); // y = a0 + a1*x + a2*x^2 + ...
                }

                // Error cuadrático residual (diferencia entre valor predicho y real)
                sr += Math.Pow((yPredicho - y), 2);

                // Error cuadrático total (diferencia entre promedio de Y y valor real)
                st += Math.Pow((promedioY - y), 2);
            }

            // Calculamos el coeficiente de correlación r
            double r = Math.Sqrt((st - sr) / st) * 100;

            // Retornamos la matriz, la función polinómica y el coeficiente de correlación
            return (matriz, funcion, r);
        }
    }
}








