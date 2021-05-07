using System;
using System.Collections.Generic;

namespace ListaEj1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            Random rnd = new Random();

            int i,numero, aleatorio;
            float suma, promedio;
            suma = 0;
            promedio = 0;


            for (i = 0; i < 25; i++)
            {

                numero = int.Parse(Console.ReadLine());
                aleatorio = rnd.Next(1, 100);
                lista.Add(aleatorio);

            }

            foreach(int num in lista)
            {
                Console.WriteLine(num);
            }

            foreach (float num in lista)
            {
                suma = suma + num;
            }

            promedio = suma / 25;

            Console.WriteLine("La suma es = " + suma);
            Console.WriteLine("El promedio es = " + promedio);

            Console.ReadKey();
        }

    }
}
