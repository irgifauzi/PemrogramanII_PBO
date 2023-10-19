using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4_1_714220035
{
    public class Product_714220035
    {
       private string myType;
       private string myTitle;
            public Product_714220035()
            {

            }

        public Product_714220035(string type, string title)
        {
            this.myType = type;
            this.myTitle = title;            
        }   

        public string Mytype
        {
            get { return myType; }
            set { myType = value; }
        }

        public string MyTitle
        {
            get { return myTitle; }
            set { myTitle = value; }
        }
    }
}
