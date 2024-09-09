using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Metodos.Unidad_2
{
    public class Gauss_Seidel
    {
        public ResultadoUnidad2 UseMethod(double[,] matriz, double tolerancia, int cantidadIteraciones)
        {
            int dimension = matriz.GetLength(0);
            double[] soluciones = new double[dimension];
            double[] anteriores = new double[dimension];

            // Inicializar el vector de soluciones
            for (int i = 0; i < dimension; i++)
            {
                soluciones[i] = 0.0; // Puedes inicializar en otro valor si lo deseas
            }

            int iteracion = 0;
            bool convergencia = false;

            while (!convergencia && iteracion < cantidadIteraciones)
            {
                iteracion++;
                convergencia = true; // Asumimos que converge en esta iteración

                for (int i = 0; i < dimension; i++)
                {
                    double suma = matriz[i, dimension]; // Término independiente

                    for (int j = 0; j < dimension; j++)
                    {
                        if (i != j)
                        {
                            suma -= matriz[i, j] * soluciones[j]; // Resto el valor conocido multiplicado por la incógnita
                        }
                    }

                    // Calcular nueva solución para x_i
                    double nuevaSolucion = suma / matriz[i, i];

                    // Verificar el criterio de convergencia
                    if (Math.Abs(nuevaSolucion - soluciones[i]) > tolerancia)
                    {
                        convergencia = false;
                    }

                    anteriores[i] = soluciones[i];
                    soluciones[i] = nuevaSolucion; // Actualizar la solución
                }
            }

            if (iteracion >= cantidadIteraciones)
            {
                return new ResultadoUnidad2
                {
                    Sucess = false,
                    MensajeError = "El método no convergió después del número máximo de iteraciones.",
                    VectorResultante = anteriores // Devolver las soluciones aproximadas antes de detenerse
                };
            }

            return new ResultadoUnidad2
            {
                Sucess = true,
                MensajeError = string.Empty,
                VectorResultante = soluciones,
                CantidadIteraciones = iteracion
            };
        }
    }
}