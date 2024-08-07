using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisisNumericos
{
    public class Resultado
    {
        public double ValorXr { get; set; }
        public int CantidadIteraciones { get; set; }
        public double ErrorRelativo { get; set; }
        public bool Converge { get; set; }
        public bool Sucess {  get; set; }

    }
}
