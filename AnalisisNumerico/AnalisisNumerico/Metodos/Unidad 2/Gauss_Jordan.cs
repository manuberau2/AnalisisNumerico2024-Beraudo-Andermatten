using AnalisisNumericos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Metodos.Unidad_2
{
    public class Gauss_Jordan
    {
        public ResultadoUnidad2 UseMethod(double[,] matriz)
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            // Verificar si la matriz es compatible (n ecuaciones y n+1 columnas)
            if (filas + 1 != columnas)
            {
                return new ResultadoUnidad2
                {
                    Sucess = false,
                    MensajeError = "La matriz no tiene el tamaño adecuado para un sistema de ecuaciones.",
                    VectorResultante = null
                };
            }

            // Algoritmo de Gauss-Jordan
            for (int i = 0; i < filas; i++)
            {
                // Verificar si el elemento de la diagonal es cero, intercambiar filas si es necesario
                if (matriz[i, i] == 0)
                {
                    bool intercambiada = false;
                    for (int j = i + 1; j < filas; j++)
                    {
                        if (matriz[j, i] != 0)
                        {
                            IntercambiarFilas(matriz, i, j);
                            intercambiada = true;
                            break;
                        }
                    }
                    if (!intercambiada)
                    {
                        return new ResultadoUnidad2
                        {
                            Sucess = false,
                            MensajeError = "El sistema no tiene solución única.",
                            VectorResultante = null
                        };
                    }
                }

                // Hacer el pivote igual a 1
                double pivote = matriz[i, i];
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] /= pivote;
                }

                // Hacer cero los otros elementos de la columna actual
                for (int j = 0; j < filas; j++)
                {
                    if (j != i)
                    {
                        double factor = matriz[j, i];
                        for (int k = 0; k < columnas; k++)
                        {
                            matriz[j, k] -= factor * matriz[i, k];
                        }
                    }
                }
            }

            // Extraer el vector resultante
            double[] resultado = new double[filas];
            for (int i = 0; i < filas; i++)
            {
                resultado[i] = matriz[i, columnas - 1];
            }

            return new ResultadoUnidad2
            {
                Sucess = true,
                MensajeError = null,
                VectorResultante = resultado
            };
        }

        private void IntercambiarFilas(double[,] matriz, int fila1, int fila2)
        {
            int columnas = matriz.GetLength(1);
            for (int i = 0; i < columnas; i++)
            {
                double temp = matriz[fila1, i];
                matriz[fila1, i] = matriz[fila2, i];
                matriz[fila2, i] = temp;
            }
        }
    }
}