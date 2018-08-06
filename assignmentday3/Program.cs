using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentday3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<pizzaorder> po = new List<pizzaorder>
            {
                new pizzaorder {orderid=12,orderdate=DateTime.Now,pizzatype="veg",pizzasize='s',toppings="sweet corn",qty=2,prize=625 },
                new pizzaorder {orderid=13,orderdate=DateTime.Now,pizzatype=" non veg",pizzasize='m',toppings="egg",qty=2,prize=800 },

                new pizzaorder {orderid=14,orderdate=DateTime.Now,pizzatype="veg",pizzasize='l',toppings="onion",qty=1,prize=610 },

                new pizzaorder {orderid=15,orderdate=DateTime.Now,pizzatype=" non veg",pizzasize='s',toppings="chicken",qty=3,prize=700 },

                new pizzaorder {orderid=16,orderdate=DateTime.Now,pizzatype="veg",pizzasize='m',toppings="tomato",qty=4,prize=730 },
                new pizzaorder {orderid=17,orderdate=DateTime.Now,pizzatype="veg",pizzasize='s',toppings="capsicum",qty=2,prize=625 }
            };



            var data = from r in po
                       select r;

            foreach (var r in po)
                Console.WriteLine(r.orderid + " " + r.orderdate + " " + r.pizzatype + " " + r.pizzasize + "  " + r.toppings + "  " + r.qty + "  " + r.prize);


            Console.WriteLine("*****************************");

            var data5 = from  r in po
                        select new { ptype = r.pizzatype,psize = r.pizzasize };

            foreach (var r in data5)
                Console.WriteLine(r.ptype + "     " + r.psize);



            Console.WriteLine("*****************************");



             var data6 = from t in po
                           group t by t.pizzatype  into grp
                           select new
                           {
                               ptype = grp.Key,
                               
                               sumsqty = grp.Sum(X => X.qty),
                               sumamt = grp.Sum(y=>y.prize)
                           };


               foreach (var d in data6)
                   Console.WriteLine(d.ptype + " " + d.sumsqty + " " + d.sumamt);

               Console.WriteLine("*****************************");


            var data8 = from t in po
                        group t by t.pizzasize into grp
                        select new
                        {
                            ptype = grp.Key,

                            sumsqty = grp.Sum(X => X.qty),
                            sumamt = grp.Sum(y => y.prize)
                        };


            foreach (var d in data8)
                Console.WriteLine(d.ptype + " " + d.sumsqty + " " + d.sumamt);

            Console.WriteLine("*****************************");


            var data2 = from t in po
                        where  t.pizzasize == 'm' || t.pizzasize == 'm'
                        select  new
                        {
                            Ptype = t.pizzatype,
                            top = t.toppings
                        };




            foreach (var h in data2)
                Console.WriteLine(h.Ptype + " " + h.top);
            Console.WriteLine("**************");


            var data7 = from t in po
                        where t.prize == po.Max(x => x.prize)
                        select t;
            foreach (var r in data7)
                Console.WriteLine(r.orderid + " " + r.orderdate + " " + r.pizzatype + " " + r.pizzasize + "  " + r.toppings + "  " + r.qty + "  " + r.prize);

            Console.WriteLine("*****************************");

            var data9 = from t in po
                        where t.prize == po.Min(x => x.prize)
                        select t;
            foreach (var r in data9)
                Console.WriteLine(r.orderid + " " + r.orderdate + " " + r.pizzatype + " " + r.pizzasize + "  " + r.toppings + "  " + r.qty + "  " + r.prize);

            Console.WriteLine("*****************************");













        }
    }
}
