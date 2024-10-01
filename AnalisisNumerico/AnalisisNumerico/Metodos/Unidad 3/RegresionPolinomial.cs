using AnalisisNumerico.Metodos.Unidad_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Metodos.Unidad_3
{
    public class RegresionPolinomial
    {
        public static double[,] GenerarMatrizPolinomial(int grado, List<double[]> puntosCargados, double tolerancia)
        {
            int dimension = grado + 1;
            double[,] matriz = new double[dimension, dimension + 1];

            foreach (var punto in puntosCargados)
            {
                double x = punto[0];
                double y = punto[1];

                for (int fila = 0; fila < dimension; fila++)
                {
                    for (int col = 0; col < dimension; col++)
                    {
                        double valor = Math.Pow(x, fila + col);

                        if (Math.Abs(valor) < tolerancia)
                        {
                            valor = 0; // Aplicamos la tolerancia para valores muy pequeños
                        }

                        matriz[fila, col] += valor;
                    }

                    double terminoIndependiente = y * Math.Pow(x, fila);

                    if (Math.Abs(terminoIndependiente) < tolerancia)
                    {
                        terminoIndependiente = 0; // Aplicamos la tolerancia para el término independiente
                    }

                    matriz[fila, dimension] += terminoIndependiente;
                }
            }

            return matriz;
        }
        public static double[] ResolverPolinomio(int grado, List<double[]> puntosCargados, double tolerancia)
        {
            // Generamos la matriz polinomial
            double[,] matrizPolinomial = GenerarMatrizPolinomial(grado, puntosCargados, tolerancia);

            // Creamos una instancia de Gauss_Jordan y resolvemos el sistema
            Gauss_Jordan gaussJordan = new Gauss_Jordan();
            ResultadoUnidad2 resultado = gaussJordan.UseMethod(matrizPolinomial);

            // Verificamos si la resolución fue exitosa
            if (!resultado.Sucess)
            {
                throw new InvalidOperationException(resultado.MensajeError);
            }

            // Devolvemos el vector resultante de coeficientes
            return resultado.VectorResultante;
        }
        public string ConstruirFuncionPolinomica(double[] resultado)
        {
            string funcion = "y = ";
            int grado = resultado.Length - 1;

            for (int i = 0; i <= grado; i++)
            {
                if (i > 0 && resultado[i] >= 0)
                {
                    funcion += " + ";
                }
                else if (i > 0 && resultado[i] < 0)
                {
                    funcion += " - ";
                    resultado[i] = Math.Abs(resultado[i]);
                }

                funcion += $"{resultado[i]}";
                if (grado - i > 0)
                {
                    funcion += $" x^{grado - i}";
                }
            }
            return funcion;
        }
        public double CalcularCoeficienteCorrelacion(List<double[]> puntosCargados, double[] resultado)
        {
            double sr = 0, st = 0;
            double promedioY = puntosCargados.Average(punto => punto[1]);

            foreach (var punto in puntosCargados)
            {
                double yObservado = punto[1];
                double x = punto[0];
                double yPredicho = 0;

                for (int i = 0; i < resultado.Length; i++)
                {
                    yPredicho += resultado[i] * Math.Pow(x, resultado.Length - 1 - i);
                }

                sr += Math.Pow(yObservado - yPredicho, 2);
                st += Math.Pow(yObservado - promedioY, 2);
            }

            return Math.Sqrt((st - sr) / st);
        }
        public string EvaluarEfectividadDelAjuste(double coeficienteCorrelacion)
        {
            if (coeficienteCorrelacion > 0.9)
                return "El ajuste es excelente";
            else if (coeficienteCorrelacion > 0.8)
                return "El ajuste es aceptable";
            else
                return "El ajuste es insuficiente";
        }


    }
}