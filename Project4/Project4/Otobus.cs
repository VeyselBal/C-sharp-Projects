using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    public class Otobus
    {
        string seferAdi;
        string seferSaati;
        string model;
        int koltukSayisi;

        public Otobus(string seferAdi, string seferSaati, string model, int koltukSayisi)
        {
            this.seferAdi = seferAdi;
            this.seferSaati = seferSaati;   
            this.model = model; 
            this.koltukSayisi = koltukSayisi;
        }
        public string SeferAdi { get { return seferAdi; } set { seferAdi = value; } }
        public string SeferSaati { get { return seferSaati; } set { seferSaati = value; } }
        public string Model { get { return model; } set { model = value; } }
        public int KoltukSayisi { get { return koltukSayisi; } set { koltukSayisi = value; } }
    }
}
