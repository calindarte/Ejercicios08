using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios08
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("recorre los numeros de dos en dos");
            
            for (int i= 1; i<=100; i++)
            {
                if( (i%2) == 0)
                {
                    Console.Write(i + "  ");
                }
            }
                

            Console.ReadLine();
        }
    }
}
