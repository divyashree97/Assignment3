using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment31
{
    [AttributeUsage(AttributeTargets.Method)]
    class methodinfo:Attribute
    {
        public string methodname { get; set; }
        public string returntype { get; set; }
        public string parameters{ get; set; }
        public string message { get; set; }


    }
}
