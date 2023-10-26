using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4_2_714220035
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //inheritance
            Console.WriteLine("Inheritance");
            Jenis a  = new Jenis();
            Console.WriteLine(a.Produk);
            Console.WriteLine(a.jenis_produk);
            Console.WriteLine(a.Harga_produk);
            a.diskon();
            a.diskon2();

            //Polymorphism
            Console.WriteLine("Polymorphism");
            Indomaret b = new Chitato();
            b.Makanan();
            Indomaret c = new Silver_Queen();
            c.Makanan();

            //FieldProperty
            Console.WriteLine("FieldProperty");
            Toko D = new Toko();
            D.jenis = "perkakas";
            D.Harga_barang = 99;
            Console.WriteLine("Barang");
            Console.WriteLine("jenis: {0}", D.jenis);
            Console.WriteLine("harga_barang: {0}", D.Harga_barang);


            //constructor
            Console.WriteLine("Constructor:");
            Sosis suka = new Sosis 
            { nama_makanan = "Sosis Indomaret", harga = 10000, rasa = 
            "Gurih Pedas" };
            Console.WriteLine(suka.nama_makanan);
            Console.WriteLine(suka.harga);
            Console.WriteLine(suka.rasa);
           

        }
    }
}
