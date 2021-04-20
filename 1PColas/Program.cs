using System;
using System.Collections;
using System.Collections.Generic;

namespace _1PColas
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> Numeros = new Queue<int>();

            void InsertarCola()
            {
                Numeros.Enqueue(1);
                Numeros.Enqueue(2);
                Numeros.Enqueue(3);
                Numeros.Enqueue(4);
                Numeros.Enqueue(5);
                Numeros.Enqueue(6);
                Numeros.Enqueue(7);
                Numeros.Enqueue(8);
                Numeros.Enqueue(9);
                Numeros.Enqueue(10);
            }

            Console.WriteLine("Cola:");

            void ImprimirCola()
            {
                while (Numeros.Count > 0)
                {

                    Console.WriteLine(Numeros.Dequeue());

                }
            }



        }

       
    }
}
