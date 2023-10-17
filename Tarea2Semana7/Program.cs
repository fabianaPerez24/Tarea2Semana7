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
           
            int vida = 10;
            List<string> words = new List<string>();

            words.Add("rojo");
            words.Add("azul");
            words.Add("verde");
            words.Add("amarillo");
            words.Add("morado");
            words.Add("marron");

            Console.WriteLine("Elige un numero del 1 al 6");

            string option = Console.ReadLine();
            switch(option)
            {
                case "1":

                    List<string>rojo=new List<string>();
                    rojo.Add("r");
                    rojo.Add("o");
                    rojo.Add("j");



                    break;
            }



            List<string>azul =new List<string>();
            azul.Add("a");
            azul.Add("z");
            azul.Add("u");
            azul.Add("l");

            List<string>verde =new List<string>();
            verde.Add("v");
            verde.Add("e");
            verde.Add("r");
            verde.Add("d");

        }
    }
}
