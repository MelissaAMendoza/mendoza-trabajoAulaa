using System;
using System.Collections.Generic;

namespace ListasEj4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<string> semana = new List<string>();

            semana.Add("LUNES");
            semana.Add("MARTES");
            semana.Add("MIERCOLES");
            semana.Add("JUEVES");
            semana.Add("VIERNES");
            semana.Add("SABADO");
            semana.Add("DOMINGO");

            int i;

            i = 6;

            imprimeListaInversa(i);

            void imprimeListaInversa(int x)
            {
                if (x >= 0)
                {
                    Console.WriteLine(semana[x]);

                    x--;

                    imprimeListaInversa(x);
                }
            }

            // Metodo Reverse para invertir una lista
            /*
                semana.Reverse();

            foreach (string dia in semana)
            {
                Console.WriteLine(dia);
            }*/

        }

    }
}