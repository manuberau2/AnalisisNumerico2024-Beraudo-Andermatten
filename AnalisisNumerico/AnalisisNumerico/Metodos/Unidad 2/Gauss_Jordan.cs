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
        public ResultadoUnidad2 GaussJordan(double[,] matriz)
        {
            ResultadoUnidad2 res = new ResultadoUnidad2();
            int tamanio = matriz.GetLength(0);

            for (int i = 0; i < tamanio; i++)
            {
                int elementomayorcolumna = i;

                // Encontrar el mayor elemento en la columna para intercambiar filas
                for (int k = i + 1; k < tamanio; k++)
                {
                    if (Math.Abs(matriz[k, i]) > Math.Abs(matriz[elementomayorcolumna, i]))
                    {
                        elementomayorcolumna = k;
                    }
                }

                // Intercambiar filas si es necesario
                if (elementomayorcolumna != i)
                {
                    for (int j = 0; j < tamanio + 1; j++)  // Incluir términos independientes
                    {
                        double aux = matriz[i, j];
                        matriz[i, j] = matriz[elementomayorcolumna, j];
                        matriz[elementomayorcolumna, j] = aux;
                    }
                }

                // Dividir la fila por el elemento diagonal
                double elementoDiagonal = matriz[i, i];
                for (int j = 0; j < tamanio + 1; j++) // Incluir términos independientes
                {
                    matriz[i, j] /= elementoDiagonal;
                }

                // Reducir las demás filas
                for (int k = 0; k < tamanio; k++)
                {
                    if (k != i)
                    {
                        double factor = matriz[k, i];
                        for (int j = 0; j < tamanio + 1; j++) // Incluir términos independientes
                        {
                            matriz[k, j] -= factor * matriz[i, j];
                        }
                    }
                }
            }

            res.Sucess = true;
            res.MatrizResultado = matriz;
            res.MensajeError = null;
            return res;
        }
    }
}