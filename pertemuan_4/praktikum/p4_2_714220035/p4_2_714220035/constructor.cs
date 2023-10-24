using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4_2_714220035
{
    internal class constructor
    {
    }
    public class Sosis
    {
        public string nama_makanan;
        public int harga;
        public string rasa;
        

        public Sosis()
        {
            this.nama_makanan = "Sosis Indomaret";
            this.harga = 10000;
            this.rasa = "Gurih Pedas";

        }  
        public Sosis(string nama_makanan, int harga, string rasa)
        {
            this.nama_makanan = nama_makanan;
            this.harga = harga;
            this.rasa = rasa;
          
         
        }
    }
}

