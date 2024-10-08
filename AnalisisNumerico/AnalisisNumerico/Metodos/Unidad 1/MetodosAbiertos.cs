﻿using AnalisisNumericos;
using Calculus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumerico.Metodos.Unidad_1
{
    public class MetodosAbiertos
    {
        public Resultado UseNewtonRaphson(string funcion, double tolerancia, int cantidadIteraciones, double xi)
        {
            Resultado rta = new Resultado();
            Calculo analizadorFuncion = new Calculo();
            int contadorIteraciones = 0;
            double xr = xi;
            double errorRelativo = double.MaxValue;
            analizadorFuncion.Sintaxis(funcion, 'x');

            // Bucle que se ejecuta mientras no se alcance la tolerancia o el máximo de iteraciones
            while (contadorIteraciones < cantidadIteraciones && errorRelativo > tolerancia)
            {
                // Evaluamos la función y su derivada en el punto xi
                double fxi = analizadorFuncion.EvaluaFx(xi);
                double derivada = (analizadorFuncion.EvaluaFx(xi + tolerancia) - fxi) / tolerancia;

                if (Math.Abs(derivada) < tolerancia)
                {
                    rta.Sucess = false;
                    rta.Converge = false;
                    rta.ValorXr = double.NaN;
                    rta.ErrorRelativo = errorRelativo;
                    rta.CantidadIteraciones = contadorIteraciones;
                    return rta;
                }

                // Calculamos el siguiente valor de xr usando Newton-Raphson
                xr = xi - (fxi / derivada);
                if (double.IsNaN(xr) || double.IsInfinity(xr))
                {
                    rta.Sucess = false;
                    rta.Converge = false;
                    return rta;
                }

                // Calculamos el error relativo
                errorRelativo = Math.Abs((xr - xi) / xr);

                // Si el error es menor que la tolerancia, hemos encontrado la raíz
                if (errorRelativo < tolerancia)
                {
                    rta.ValorXr = xr;
                    rta.ErrorRelativo = errorRelativo;
                    rta.Sucess = true;
                    rta.Converge = true;
                    rta.CantidadIteraciones = contadorIteraciones;
                    return rta;
                }

                // Preparamos para la siguiente iteración
                xi = xr;
                contadorIteraciones++;
            }

            // Si salimos del bucle, puede ser que no convergió
            rta.ValorXr = xr;
            rta.ErrorRelativo = errorRelativo;
            rta.Sucess = errorRelativo < tolerancia;
            rta.Converge = rta.Sucess;
            rta.CantidadIteraciones = contadorIteraciones;

            return rta;
        }



        public Resultado UseSecante(string funcion, double tolerancia, int cantidadIteraciones, double xi, double xd)
        {
            Resultado resultado = new Resultado();
            Calculo analizadorFuncion = new Calculo();
            int contadorIteraciones = 0;

            analizadorFuncion.Sintaxis(funcion, 'x');

            // Comprobar si xi o xd ya son raíces
            if (analizadorFuncion.EvaluaFx(xi) == 0)
            {
                resultado.ValorXr = xi;
                resultado.Converge = true;
                resultado.Sucess = true;
                return resultado;
            }
            if (analizadorFuncion.EvaluaFx(xd) == 0)
            {
                resultado.ValorXr = xd;
                resultado.Converge = true;
                resultado.Sucess = true;
                return resultado;
            }

            double error = 0;
            double xr = 0;

            while (contadorIteraciones < cantidadIteraciones)
            {
                contadorIteraciones++;
                // Verificar si se produce un NaN o infinito
                double fxi = analizadorFuncion.EvaluaFx(xi);
                double fxd = analizadorFuncion.EvaluaFx(xd);

                if (fxi == fxd)
                {
                    resultado.Sucess = false;
                    resultado.Converge = false;
                    resultado.CantidadIteraciones = contadorIteraciones;
                    return resultado;
                }

                double denominador = fxi - fxd;
                xr = (fxi * xd - fxd * xi) / denominador;
                if (double.IsNaN(xr) || double.IsInfinity(xr))
                {
                    resultado.Sucess = false;
                    resultado.Converge = false;
                    resultado.CantidadIteraciones = contadorIteraciones;
                    return resultado;
                }

                error = Math.Abs((xr - xd) / xr);


                if (error < tolerancia)
                {
                    resultado.ValorXr = xr;
                    resultado.ErrorRelativo = error;
                    resultado.CantidadIteraciones = contadorIteraciones;
                    resultado.Sucess = true;
                    resultado.Converge = true;
                    return resultado;
                }
                xi = xd;
                xd = xr;
            }

            resultado.Sucess = true;
            resultado.Converge = false;
            resultado.ValorXr = xr;
            resultado.CantidadIteraciones = contadorIteraciones;
            resultado.ErrorRelativo = error;
            return resultado;
        }


    }
}
