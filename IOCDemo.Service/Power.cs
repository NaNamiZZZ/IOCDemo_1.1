using IOCDemo.Interface1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCDemo.Service
{
    public class Power : IPower
    {
        //public Power(IBaseDAL BaseDAL)
        //{
        //}

        public Power()
        {
            Console.WriteLine("Power 被构造");
        }
    }
}
