using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using AnalisisNumericos;
using Calculus;
using AnalisisNumerico.Forms;

namespace AnalisisNumerico.Metodos.Unidad_1
{
    public class MetodosCerrados
    {
        public Resultado UseBiseccion(string funcion, double tolerancia, int cantidadIteraciones, double xi, double xd)
        {
            Resultado resultado = new Resultado();
            Calculo analizadorFuncion = new Calculo();
            analizadorFuncion.Sintaxis(funcion, 'x');

            double fxI = analizadorFuncion.EvaluaFx(xi);
            double fxD = analizadorFuncion.EvaluaFx(xd);

            // Verificar si uno de los extremos del intervalo es raíz
            if (fxI == 0)
            {
                resultado.ValorXr = xi;
                resultado.ErrorRelativo = 0;
                resultado.CantidadIteraciones = 0;
                resultado.Converge = true;
                resultado.Sucess = true;
                return resultado;
            }
            else if (fxD == 0)
            {
                resultado.ValorXr = xd;
                resultado.ErrorRelativo = 0;
                resultado.CantidadIteraciones = 0;
                resultado.Converge = true;
                resultado.Sucess = true;
                return resultado;
            }

            // Verificar si el intervalo es válido
            if (fxI * fxD > 0)
            {
                resultado.Sucess = false;
                resultado.Converge = false;
                return resultado; // Finalizar el método para permitir la corrección de los valores
            }

            double xrAnterior = 0;
            int contadorIteraciones = 0;

            // Lógica del método de bisección
            while (contadorIteraciones < cantidadIteraciones)
            {
                contadorIteraciones++;
                double xr = (xi + xd) / 2;
                double fxr = analizadorFuncion.EvaluaFx(xr);
                double error = (contadorIteraciones == 1) ? 0 : Math.Abs((xr - xrAnterior) / xr);

                // Verificar si se ha alcanzado la tolerancia o si el método ha convergido
                if (contadorIteraciones == 1)
                {
                    if (Math.Abs(fxr) < tolerancia)
                    {
                        resultado.ValorXr = xr;
                        resultado.ErrorRelativo = error;
                        resultado.CantidadIteraciones = contadorIteraciones;
                        resultado.Converge = true;
                        resultado.Sucess = true;
                        return resultado;
                    }
                } else
                {
                    if (Math.Abs(fxr) < tolerancia || error < tolerancia)
                    {
                        resultado.ValorXr = xr;
                        resultado.ErrorRelativo = error;
                        resultado.CantidadIteraciones = contadorIteraciones;
                        resultado.Converge = true;
                        resultado.Sucess = true;
                        return resultado;
                    }
                }
                if (fxI * fxr < 0)
                {
                    xd = xr;
                    fxD = fxr;
                }
                else
                {
                    xi = xr;
                    fxI = fxr;
                }

                xrAnterior = xr;
            }

            // Si se alcanzó el máximo de iteraciones sin converger
            resultado.ValorXr = (xi + xd) / 2;
            resultado.ErrorRelativo = Math.Abs((resultado.ValorXr - xrAnterior) / resultado.ValorXr);
            resultado.CantidadIteraciones = contadorIteraciones;
            resultado.Converge = false;
            resultado.Sucess = true;

            return resultado;
        }
        //Hay que chequear que hay que corregir en este
        public Resultado UseReglaFalsa(string funcion, double tolerancia, int cantidadIteraciones)
        {
            Resultado resultado = new Resultado();
            Calculo analizadorFuncion = new Calculo();
            double xrAnterior = 0;
            int contadorIteraciones = 0;

            Console.WriteLine("Ingrese el valor de xi:");
            double xi = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de xd:");
            double xd = double.Parse(Console.ReadLine());

            // Lógica para cuando se ingresa el intervalo y uno de los extremos es raíz o los extremos no contienen la raíz.
            while (analizadorFuncion.EvaluaFx(xi) * analizadorFuncion.EvaluaFx(xd) >= 0)
            {
                if (analizadorFuncion.EvaluaFx(xi) * analizadorFuncion.EvaluaFx(xd) == 0)
                {
                    resultado.ValorXr = analizadorFuncion.EvaluaFx(xi) == 0 ? xi : xd;
                    resultado.ErrorRelativo = 0;
                    resultado.CantidadIteraciones = contadorIteraciones;
                    resultado.Sucess = true;
                    break;
                }
                Console.WriteLine($"El intervalo [{xi}, {xd}] no contiene a la raíz. Ingrese nuevamente el intervalo.");
                Console.WriteLine("Ingrese el valor de xi:");
                xi = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el valor de xd:");
                xd = double.Parse(Console.ReadLine());
            }

            if (resultado.Sucess) return resultado;

            // Lógica para hacer el método de la Regla Falsa en sí.
            while (true)
            {
                contadorIteraciones++;
                double fxi = analizadorFuncion.EvaluaFx(xi);
                double fxd = analizadorFuncion.EvaluaFx(xd);
                double xr = xd - (fxd * (xd - xi)) / (fxd - fxi);
                double fxr = analizadorFuncion.EvaluaFx(xr);

                double error = Math.Abs((xr - xrAnterior) / xr);

                if (fxr < tolerancia || contadorIteraciones > cantidadIteraciones || error < tolerancia)
                {
                    resultado.ValorXr = xr;
                    resultado.ErrorRelativo = error;
                    resultado.CantidadIteraciones = contadorIteraciones;
                    resultado.Sucess = true;
                    break;
                }
                else
                {
                    if (fxi * fxr < 0)
                    {
                        xd = xr;
                    }
                    else
                    {
                        xi = xr;
                    }
                    xrAnterior = xr;
                }
            }

            return resultado;
        }
    }
}
