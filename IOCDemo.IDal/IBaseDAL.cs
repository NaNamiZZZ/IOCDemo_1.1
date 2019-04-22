using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCDemo.IDal
{
    public interface IBaseDAL
    {
        void Add();

        void Delete();
        void Update();
        void Find();
    }
}
