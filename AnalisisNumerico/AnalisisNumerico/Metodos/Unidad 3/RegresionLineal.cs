using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Metodos.Unidad_3
{
    public class RegresionLineal
    {
        public static (string function, double r, string efectividad) CalcularRegresionLineal(List<double[]> puntoscargados, double tolerancia)
        {
            int n = puntoscargados.Count;
            double sumX = 0, sumY = 0, sumXY = 0, sumX2 = 0;

            foreach (var punto in puntoscargados)
            {
                double x = punto[0];
                double y = punto[1];
                sumX += x;
                sumY += y;
                sumXY += x * y;
                sumX2 += x * x;
            }
            double a1 = (n * sumXY - sumX * sumY) / (n * sumX2 - (sumX * sumX));

            double a0 = (sumY / n) - a1 * (sumX / n);

            double sr = 0, st = 0;
            double promedioY = sumY / n;

            foreach (var punto in puntoscargados)
            {
                double x = punto[0];
                double y = punto[1];

                st += Math.Pow(promedioY - y, 2); 
                sr += Math.Pow((a1 * x + a0) - y, 2);
            }

            double r = Math.Sqrt((st - sr) / st) * 100;
            string efectividad;
            if (r > tolerancia)
            {
                efectividad = "El ajuste es aceptable";
            }
            else
            {
                efectividad = "El ajuste es insuficiente";
            }
            string funcion = $"y = {a1}x + {a0}";
            return (funcion, r, efectividad);
        }
    }
}
