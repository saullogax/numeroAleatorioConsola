using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace NumeroAleatorio
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Random rnd = new Random();

            Console.WriteLine("Ingrese el primer número:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            num2 = int.Parse(Console.ReadLine());
            
           
            Console.WriteLine("--------------------------------------------------------");

            int f;
            for (f = num1; f <= num2; f++)
            {
                Console.WriteLine(rnd.Next(f));
            }

                Console.ReadLine();
        }
    }
}
