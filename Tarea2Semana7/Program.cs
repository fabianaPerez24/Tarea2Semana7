using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2Semana7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> palabra = new(new string[] { "rojo", "azul", "verde", "amarillo" });

            Random r = new Random();
            Salud health = new Salud(10);
            Palabras word = new Palabras(palabra[r.Next(palabra.Count)]);

            while (health.IsAlive() && !word.IsComplete())
            {
                Console.Clear();
                Console.WriteLine($"vidas: {health.CurrentLives()}");
                Console.WriteLine(word.DisplayText());

                string key = Console.ReadLine();
                if (!word.Comparar(key[0])) health.RemoveHealth(1);
            }
        }
    }
}
