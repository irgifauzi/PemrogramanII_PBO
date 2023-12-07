using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4_2_714220035
{
    internal class FieldProperty
    {
    }
    public class Toko
    {
        public string jenis;
        private int harga_barang;

        public int Harga_barang
        {
            get { return harga_barang; }
            set
            {
                if (value > 100)
                    harga_barang = value;
            }
        }
    }

}
