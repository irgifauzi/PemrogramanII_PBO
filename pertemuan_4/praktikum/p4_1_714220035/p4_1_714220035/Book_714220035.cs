using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p4_1_714220035
{
    public class Book_714220035: Product_714220035
    {
        protected string pagecount;

        public Book_714220035(string type, string title, string pagecount): base(type,title)
        {
            this.pagecount = pagecount;
        }
        public string PageCount
        {
            get
            {
                return this.pagecount;
            }
            set
            {
                pagecount = value;
            }
        }

    }
}