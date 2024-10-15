using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculus;

namespace AnalisisNumerico.Metodos.Unidad_4
{
    public class IntegralTrapecios
    {
        public double CalcularTrapecioSimple(string funcion, double xi, double xd)
        {
            Calculo Func = new Calculo();
            if (Func.Sintaxis(funcion, 'x'))
            {
                return ((Func.EvaluaFx(xi) + Func.EvaluaFx(xd)) * (xd - xi)) / 2;
            } else
            {
                return double.NaN;
            }
        }

        public double CalcularIntegralTrapecioMultiple(string funcion, double xi, double xd, int n)
        {
            Calculo Func = new Calculo();
            if(Func.Sintaxis(funcion, 'x'))
            {
                double h = (xd - xi) / n;
                double sum = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += Func.EvaluaFx(xi + h * i);
                } 
                return (h/2) * (Func.EvaluaFx(xi) + 2*sum + Func.EvaluaFx(xd));
            } else
            {
                return double.NaN;
            }
        }
    }
}
