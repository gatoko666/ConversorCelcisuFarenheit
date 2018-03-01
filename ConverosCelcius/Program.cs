using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Escribir un método que acepte un double que represente un número en grados Celcius y lo transforme a grados Fahrenheit.



namespace ConverosCelcius
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                try
                {
                            Console.WriteLine("Ingrese grados Celcius :");
                            string palabra1 = Console.ReadLine();
                            double celcius = int.Parse(palabra1);
                            double farenheit;
                            farenheit = (celcius*1.8) + 32;
                            Console.WriteLine("Los grados Farenheit son "+farenheit+ " ºF");


                            Console.Read();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Escribe algún valor válido");
                }

            }
        }
    }
}
