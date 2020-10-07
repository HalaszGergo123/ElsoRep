using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("Intrati numarul de pantof: ");
            string line;
            line = Console.ReadLine();

            int numarPantof;
            try
            {
                numarPantof = int.Parse(line);
                
                Console.WriteLine($"Aveti {numarPantof} pantofi");
            }
            catch (FormatException e)
            {

                Console.WriteLine(e.Message);
            }

            //int.TryParse(line,out numarPantof );
        }
    }
}
