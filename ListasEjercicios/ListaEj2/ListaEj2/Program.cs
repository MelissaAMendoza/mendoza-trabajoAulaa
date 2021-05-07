using System;
using System.Collections.Generic;

namespace ListaEj2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("A");
            lista.Add("B");
            lista.Add("C");
            lista.Add("D");
            lista.Add("E");
            lista.Add("F");
            lista.Add("G");
            lista.Add("H");
            lista.Add("I");
            lista.Add("J");

            foreach (string abc in lista)
            {
                Console.WriteLine("\t"+abc);
            }

            Console.WriteLine();
            Console.WriteLine(" La lista de caracteres en orden inverso es:");

            //Impresion de caracteres en orden inverso
            lista.Reverse();

            foreach (string abc in lista)
            {
                Console.WriteLine("\t"+abc);
            }

            Console.ReadKey();
        }

        
    }

}
