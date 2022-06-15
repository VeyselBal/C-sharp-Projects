using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Insan
    {
        int boy, kilo, yas;

        public Insan()
        {
            yas = 1;
            Console.WriteLine("bir insan oluşturuldu");
        }

        public Insan(int boy, int kilo, int yas)
        {
            this.boy = boy;
            this.kilo = kilo;
            this.yas = yas;
        }

        public override string ToString()
        {
            return "İnsanın boyu: " + boy + " kilo: " + kilo + " yas: " + yas;
        }

        public void yemek()
        {

        }
    }
    public class Calisan : Insan
    {
        double maas;

        public void zam(double oran)
        {
            maas = maas + maas * oran;
        }
    }
}
