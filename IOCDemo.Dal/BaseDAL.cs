﻿using IOCDemo.IDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCDemo.Dal
{
    public class BaseDAL : IBaseDAL
    {
        public void Add()
        {
            Console.WriteLine($"{nameof(Add)}");
        }

        public void Delete()
        {
            Console.WriteLine($"{nameof(Delete)}");
        }

        public void Find()
        {
            Console.WriteLine($"{nameof(Find)}");
        }

        public void Update()
        {
            Console.WriteLine($"{nameof(Update)}");
        }
    }
}
