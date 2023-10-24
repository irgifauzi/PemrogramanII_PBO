using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4_2_714220035
{
    internal class Polymorphism
    {
    }
    class Indomaret
    {
        public virtual void Makanan()
        {
            Console.WriteLine("Jenis makanan di Indomaret");
        }
    }
    
     class Chitato : Indomaret
     {
        public override void Makanan()
        {
            //makanan ringan....
            Console.WriteLine("Chitato........");
        }
     }
     class Silver_Queen : Indomaret
    {

        public override void Makanan()
        {
            //makanan manis.....
            Console.WriteLine("Silver_Queen........");
        }
    }

}
