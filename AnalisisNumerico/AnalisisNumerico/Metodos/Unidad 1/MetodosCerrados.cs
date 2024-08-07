﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using AnalisisNumericos;
using Calculus;

namespace AnalisisNumerico.Metodos.Unidad_1
{
    public class MetodosCerrados
    {
        public Resultado UseBiseccion(String funcion, double tolerancia, int cantidadIteraciones)
        {
            Resultado resultado = new Resultado();
            Calculo analizadorFuncion = new Calculo();
            double xrAnterior = 0;
            int contadorIteraciones = 0;
            Console.WriteLine("Ingrese el valor de xi:");
            double xi = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de xd:");
            double xd = double.Parse(Console.ReadLine());
            //Lógica para cuando se ingresa el intervalo y una de los extremos es raíz o los extremos no contienen la raíz.
            while (analizadorFuncion.EvaluaFx(xi) * analizadorFuncion.EvaluaFx(xd) >= 0)
            {
                if (analizadorFuncion.EvaluaFx(xi) * analizadorFuncion.EvaluaFx(xd) == 0)
                {
                    if (analizadorFuncion.EvaluaFx(xi) == 0)
                    {
                        resultado.ValorXr = xi;
                    } else
                    {
                        resultado.ValorXr = xd;
                    }
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
            //Lógica para hacer el método de la biseccion en si.
            while (true)
            {
                contadorIteraciones++;
                double xr = (xi + xd) / 2;
                double error = (Math.Abs(xr - xrAnterior / xr));
                if (analizadorFuncion.EvaluaFx(xr) < tolerancia || contadorIteraciones > cantidadIteraciones || error < tolerancia)
                {
                    resultado.ValorXr = xr;
                    resultado.ErrorRelativo = error;
                    resultado.CantidadIteraciones = contadorIteraciones;
                    resultado.Sucess = true;
                    break;
                } else
                {
                    if (analizadorFuncion.EvaluaFx(xi) * analizadorFuncion.EvaluaFx(xr) < 0)
                    {
                        xd = xr;
                    } else
                    {
                        xi = xr;
                    }
                    xrAnterior = xr;
                }
            }
            return resultado;
        }

        //Hay que chequear que hay que corregir en este
        public Resultado UseReglaFalsa(String funcion, double tolerancia, int cantidadIteraciones)
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
