using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2_1_714220035
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan angka Pertama");
            int angka1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukan angka Kedua");
            int angka2 = Convert.ToInt32(Console.ReadLine());
            int penjumlahan;
            int pengurangan;
            int perkalian;
            float pembagian;

            penjumlahan = angka1 + angka2;
            pengurangan = angka1 - angka2;
            perkalian = angka1 * angka2;
            pembagian = (float)angka1 / angka2;

            Console.WriteLine($"{angka1} + {angka2} = {penjumlahan}");
            Console.WriteLine($"{angka1} - {angka2} = {pengurangan}");
            Console.WriteLine($"{angka1} * {angka2} = {perkalian}");
            Console.WriteLine($"{angka1} / {angka2} = {pembagian}");
        }
    }
}
