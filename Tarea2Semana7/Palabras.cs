using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Semana7
{
    internal class Palabras
    {
        public string resultado;
        public string actual;
        public Palabras(string texto)
        {
            this.resultado = texto;
            this.actual = "";

            for(int i = 0; i < texto.Length; i++)
            {
                this.actual += "_";
            }
        }
    }
}
