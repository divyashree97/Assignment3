using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentday3
{
    class pizzaorder
    {
        public int orderid { get; set; }
        public DateTime orderdate { get; set; }
        public string pizzatype { get; set; }
        public char pizzasize { get; set; }
        public string toppings { get; set; }
        public int qty { get; set; }
        public double prize { get; set; }

    }
}
