using AnalisisNumericos;
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
        public Resultado UseNewtonRaphson(string funcion, double tolerancia, int cantidaditeraciones, double xi)
        {
            //Inicializamos las variables
            Resultado rta = new Resultado();
            Calculo analizadorFuncion = new Calculo();
            int contadoriteraciones = 0;
            double xanterior = 0;
            Console.WriteLine("Ingrese el valor de xi");
            xi = double.Parse(Console.ReadLine());
            double valorabsoluto = Math.Abs(analizadorFuncion.EvaluaFx(xi)); //Por acá habría que comenzar un while, el tema es con que condicion
            if (valorabsoluto < tolerancia) {  //Esto en caso de que xi sea la raíz de una
            rta.ValorXr = xi;
                rta.Sucess = true;
                rta.Converge = true;
                rta.ErrorRelativo = 0;
                rta.CantidadIteraciones = contadoriteraciones;
                return rta;
            }
            contadoriteraciones++;
            double derivada = ((analizadorFuncion.EvaluaFx(xi) + tolerancia ) - analizadorFuncion.EvaluaFx(xi)) / tolerancia;
            if (derivada == 0) {
                Console.WriteLine("No se encuentra la Raíz");
                rta.Sucess = false; 
                rta.Converge = false;
                rta.ValorXr = 0; //El valor sería nulo?
                rta.ErrorRelativo = 0; //Hay que ver el calculo del error relativo ((xri+1 - xri) / xri+1)
                return rta;
            }
            double xr = xi - (analizadorFuncion.EvaluaFx(xi) / derivada);
            double Error = 0; //((abs(xr - xant)) / xr)  ???
            if (Math.Abs(analizadorFuncion.EvaluaFx(xr)) < tolerancia || Error < tolerancia || cantidaditeraciones < contadoriteraciones)
            {
                rta.ValorXr = xr;
                rta.ErrorRelativo = 0;
                rta.Sucess = true;
                rta.Converge = true;
                rta.CantidadIteraciones = contadoriteraciones;
                return rta;
            }
            xanterior = xr;
            xi = xr; //acá volvería hasta arriba de donde calcula la derivada, pero el tema es que condición ponerle al while
            return rta; 
        }


        public Resultado UseSecante(string funcion, double tolerancia, int cantidadIteraciones, double xi, double xd)
        {
            Resultado resultado = new Resultado();
            Calculo analizadorFuncion = new Calculo();
            int contadorIteraciones = 0;

            analizadorFuncion.Sintaxis(funcion, 'x');

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
                if (analizadorFuncion.EvaluaFx(xi) - analizadorFuncion.EvaluaFx(xd) == 0)
                {
                    resultado.Sucess = false;
                    resultado.Converge = false;
                    return resultado;
                }

                contadorIteraciones++;
                xr = (analizadorFuncion.EvaluaFx(xi) * xd - analizadorFuncion.EvaluaFx(xd) * xi) / (analizadorFuncion.EvaluaFx(xi) - analizadorFuncion.EvaluaFx(xd));

                error = Math.Abs((xr - xd) / xr);
                xi = xd;
                xd = xr;

                if (error < tolerancia)
                {
                    resultado.ValorXr = xr;
                    resultado.ErrorRelativo = error;
                    resultado.CantidadIteraciones = contadorIteraciones;
                    resultado.Sucess = true;
                    resultado.Converge = true;
                    return resultado;
                }
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
