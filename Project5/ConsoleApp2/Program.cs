using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insan insan = new Insan();

            Console.WriteLine(insan.ToString());

            List<Insan> sinif = new List<Insan>();

            Insan insan1 = new Insan(189,45,63);
            Insan insan2 = new Insan(180,96,87);
            Insan insan3 = new Insan(175,73,49);
            Insan insan4 = new Insan(170,45,61);
            Insan insan5 = new Insan(165,58,57);

            sinif.Add(insan1);
            sinif.Add(insan2);
            sinif.Add(insan3);
            sinif.Add(insan4);
            sinif.Add(insan5);

            foreach (Insan value in sinif)
            {
                Console.WriteLine(value.ToString());
            }
            Console.ReadLine();
        }
    }
}
