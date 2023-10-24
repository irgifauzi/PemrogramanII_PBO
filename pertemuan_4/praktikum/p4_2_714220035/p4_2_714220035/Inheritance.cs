using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4_2_714220035
{
    internal class Inheritance
    {
    }
    public class Promo_Indomaret
    {
        public string Produk { get; set; }
        public string jenis_produk { get; set; }

        public int Harga_produk { get; set; }

        public void diskon()
        {
            Console.WriteLine("Diskon 100%");
        }
    }
    class Jenis : Promo_Indomaret
    {
        public Jenis()
        {
            Produk = "Coklat";
            jenis_produk = "makanan ringan";
            Harga_produk = 20000;
        }
        public void diskon2()
        {
            Console.WriteLine("Diskon 80%"); 
        }
        
        
    }
}
