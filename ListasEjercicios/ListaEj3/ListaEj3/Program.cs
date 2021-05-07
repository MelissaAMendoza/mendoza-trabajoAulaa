using System;
using System.Collections.Generic;

namespace ListaEj3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
     
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Add(5);

            foreach (int numero in lista)
            {
                Console.WriteLine(numero);
            }


            Console.ReadKey();

        }

       /* static void busquedaLista()
        {
            if ()
            {

            }




        }*/

    }
}
