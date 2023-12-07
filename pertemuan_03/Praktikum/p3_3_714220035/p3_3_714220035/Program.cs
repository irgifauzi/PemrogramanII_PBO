using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p3_3_714220035
{
    internal class Program
    {
        static void Main(string[] args)
        {
             do
 {
     Console.WriteLine("PERSEGI PANJANG");
     Console.WriteLine("1.Luas");
     Console.WriteLine("2.Keliling");

     Console.Write("Menu Pilihan: ");
     int input_menu = Convert.ToInt16(Console.ReadLine());

     if (input_menu == 1)
     {
         Console.WriteLine("MENGHITUNG PERSEGI PANJANG");
         Console.Write("Panjang Persegi Panjang: ");
         int panjang = Convert.ToInt32(Console.ReadLine());
         Console.Write("Lebar Persegi Panjang: ");
         int lebar = Convert.ToInt32(Console.ReadLine());

         int luas = panjang * lebar;
         Console.WriteLine("Luas Persegi Panjang = {0}", luas);
     }

     else if (input_menu == 2)
     {
         Console.WriteLine("MENGHITUNG KELILING PERSEGI PANJANG");
         Console.Write("Masukkan Panjang: ");
         int panjang = Convert.ToInt32(Console.ReadLine());
         Console.Write("Masukkan Lebar: ");
         int lebar = Convert.ToInt32(Console.ReadLine());

         int keliling = 2 * (panjang + lebar);
         Console.WriteLine("Luas Persegi Panjang = {0}", keliling);
     }

     else
     {
         Console.WriteLine("tidak terdeteksi");
     }
     Console.Write("\nIngin mengulang kembali? (Y/T)");
 }
 while (Console.ReadLine() == "Y");
        }
    }
}
