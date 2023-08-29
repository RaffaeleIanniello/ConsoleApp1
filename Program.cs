using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il nome della persona:");
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci il cognome della persona:");
            string cognome = Console.ReadLine();

            Console.WriteLine("Inserisci l'età della persona:");
            double età = Convert.ToDouble(Console.ReadLine());

        }
    }
}
