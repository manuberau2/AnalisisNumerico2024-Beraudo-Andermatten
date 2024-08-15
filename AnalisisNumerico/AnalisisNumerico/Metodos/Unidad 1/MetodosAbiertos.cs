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
            return resultado;
        }
    }
}
