using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Semana7
{
    internal class Palabras
    {
        public List<char> resultado;
        public List<char> actual = new List<char>();
        public Palabras(string texto)
        {
            foreach(char c in texto)
            {
                resultado.Add(c);
                actual.Add('_');
            }
        }

        public string DisplayText()
        {
            string result = "";
            foreach (char c in actual) result += c;
            return result;
        }
        public bool IsComplete()
        {
            for (int i = 0; i < resultado.Count; i++)
            {
                if (resultado[i] != actual[i]) return false;
            }
            return true;
        }

        public bool Comparar(char c)
        {
            if(!resultado.Contains(c))
            {
                return false;
            }

            for(int i =0; i<resultado.Count; i++)
            {
                if (resultado[i] == c)
                {
                    actual[i] = resultado[i];
                }
            }

            return true;
        }
    }
}
