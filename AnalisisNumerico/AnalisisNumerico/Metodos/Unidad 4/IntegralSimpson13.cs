using Calculus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Metodos.Unidad_4
{
    public class IntegralSimpson13
    {
            Calculo Func = new Calculo();
        public double CalcularIntegralSimpson13Simple(string funcion, double xi, double xd)
        {
            if (Func.Sintaxis(funcion, 'x'))
            {
                double h = (xi - xd)/2;
                return (h/3) * (Func.EvaluaFx(xi) + 4*Func.EvaluaFx(xi+h) + Func.EvaluaFx(xd));
            } else
            {
                return double.NaN;
            }
        }

        public double CalcularIntegralSimpson13Multiple(string funcion, double xi,double xd, int n)
        {
           if (Func.Sintaxis(funcion, 'x'))
            {
                double h = (xd - xi) / n;
                double sumPares = 0, sumImpares = 0;
                for (int i = 1; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        sumPares += Func.EvaluaFx(xi + h*i);
                    } else
                    {
                        sumImpares += Func.EvaluaFx(xi + h * i);
                    }
                }
                return (h/3) * (Func.EvaluaFx(xi) + 4*sumImpares + 2*sumPares + Func.EvaluaFx(xd));
            } else 
            { 
                return double.NaN; 
            }
        }

        public double CalcularIntegralSimpson38(string funcion, double xi, double xd)
        {
            if (Func.Sintaxis(funcion, 'x'))
            {
                double h = (xd - xi) / 3;
                return (3 * h / 8) * (Func.EvaluaFx(xi) + 3 * Func.EvaluaFx(xi + h) + 3 * Func.EvaluaFx(xi + 2 * h) + Func.EvaluaFx(xd)); 
            } else
            {
                return double.NaN;
            }
        }

        public double SimpsonCombinado(string funcion, double xi, double xd, int n)
        {
            if (Func.Sintaxis(funcion, 'x'))
            {
                double h = (xi - xd) / n;
                double sumPares = 0, sumImpares = 0;
                double resultado = 0;
                bool simpson38hecho = false;
                for (int i = 1; i < n; i++)
                {
                    if (n%2 == 0 && !simpson38hecho)
                    {
                        double nuevoXi = xi + h * (n - 3);
                        resultado = CalcularIntegralSimpson38(funcion, nuevoXi, xd);
                        n = n - 3;
                        xd = nuevoXi;
                        simpson38hecho = true;
                    }
                    if (i % 2 == 0)
                    {
                        sumPares += Func.EvaluaFx(xi + h * i);
                    }
                    else
                    {
                        sumImpares += Func.EvaluaFx(xi + h * i);
                    }
                }
                resultado += (h / 3) * (Func.EvaluaFx(xi) + 4 * sumImpares + 2 * sumPares + Func.EvaluaFx(xd));
               return resultado;
            } else
            {
                return double.NaN;
            }
        }
    }
}
