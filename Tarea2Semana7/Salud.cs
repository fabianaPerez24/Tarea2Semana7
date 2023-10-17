using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Semana7
{
    internal class Salud
    {
        private int vidas;

        public Salud(int amount)
        {
            vidas = amount;
        }
        public bool IsAlive()
        {
            return vidas > 0;
        }

        public string CurrentLives()
        {
            
            return vidas.ToString();
        }

        public void RemoveHealth(int amount)
        {
         vidas -= amount;
        }



    }
}
