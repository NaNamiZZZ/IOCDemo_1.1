using IOCDemo.Interface1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCDemo.Service
{
    public class Headphone : IHeadphone
    {
        public Headphone()
        {
            Console.WriteLine("Headphone 被构造");
        }
    }
}
