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
            for (int i=0; i < tamanio; i++)
            {
                int elementomayorcolumna = i;
                for (int k= i+1; k<tamanio; k++)
                {
                    if (Math.Abs(matriz[k, i]) > Math.Abs(matriz[elementomayorcolumna, i]))
                    {
                        elementomayorcolumna= k;
                    }
                }
                if (elementomayorcolumna != i)
                {
                    for (int j = 0; j< tamanio; j++)
                    {
                        double aux = matriz[i, j];
                        matriz[i, j] = matriz[elementomayorcolumna, j];
                        matriz[elementomayorcolumna, j] = aux;
                    }
                }
                double elementoDiagonal = matriz[i, i];
                
                for(int j=0; j<tamanio; j++)
                {
                    matriz[i, j] /= elementoDiagonal;
                }
                for (int k = 0; k<tamanio; k++)
                {
                    if (k != i)
                    {
                        double factor = matriz[k, i];
                        for(int j=0; j< tamanio; j++)
                        {
                            matriz[k,j] -= factor * matriz[i, j];
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
