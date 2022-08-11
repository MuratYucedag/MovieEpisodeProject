using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    internal class EntityCategory
    {
        //field
        private int categoryid;
        private string categoryname;

        //property
        public int Categoryid { get => categoryid; set => categoryid = value; }
        public string Categoryname { get => categoryname; set => categoryname = value; }
    }
}
