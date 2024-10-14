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
        private static double[,] GenerarMatrizPolinomial(List<double[]> PuntosCargados, int grado)
        {
            int n = PuntosCargados.Count;
            double[,] matriz = new double[grado + 1, grado + 2];

            // Llenar la matriz con las sumatorias necesarias
            for (int i = 0; i <= grado; i++)
            {
                for (int j = 0; j <= grado; j++)
                {
                    matriz[i, j] = PuntosCargados.Sum(p => Math.Pow(p[0], i + j));
                }
                matriz[i, grado + 1] = PuntosCargados.Sum(p => p[1] * Math.Pow(p[0], i));
            }

            return matriz;
        }

        public static (string function, double r, string efectividad) CalcularRegresionPolinomial(List<double[]> PuntosCargados, int grado, double tolerancia)
        {
            int n = PuntosCargados.Count;

            // Crear la matriz polinomial
            double[,] matrizPolinomial = GenerarMatrizPolinomial(PuntosCargados, grado);

            // Llamar al método de Gauss-Jordan para obtener los coeficientes
            Gauss_Jordan gaussJordan = new Gauss_Jordan();
            ResultadoUnidad2 resultado = gaussJordan.UseMethod(matrizPolinomial);

            if (!resultado.Sucess)
            {
                throw new Exception(resultado.MensajeError);
            }

            // Los coeficientes se almacenan en 'resultado.VectorResultante'
            double[] coeficientes = resultado.VectorResultante;

            // Calcular sr y st
            double sr = 0, st = 0;
            double promedioY = PuntosCargados.Sum(p => p[1]) / n;

            foreach (var punto in PuntosCargados)
            {
                double x = punto[0];
                double y = punto[1];

                st += Math.Pow(promedioY - y, 2);
                double yAjustado = 0;

                // Calcular el valor ajustado para la función polinómica
                for (int i = 0; i <= grado; i++)
                {
                    yAjustado += coeficientes[i] * Math.Pow(x, i);
                }
                sr += Math.Pow(yAjustado - y, 2);
            }

            // Calcular coeficiente de correlación r
            double r = Math.Sqrt((st - sr) / st) * 100;

            // Efectividad del ajuste
            string efectividad = r >= tolerancia ? "El ajuste es aceptable" : "El ajuste es insuficiente";

            // Crear la función como string
            string funcion = "y = ";
            for (int i = grado; i >= 0; i--)
            {
                if (i < grado)
                {
                    funcion += " + ";
                }
                funcion += $"{coeficientes[i]}x^{i}";
            }

            return (funcion, r, efectividad);
        }
    }
}