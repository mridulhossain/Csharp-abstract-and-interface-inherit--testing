using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class DataAccess : test,ITest
    {
        public virtual void Connect()
        {
            Console.WriteLine("connected");
        }

        public abstract int Count();

        public void testInterface()
        {
            Console.WriteLine("Implemented from interface");
        }
    }
}
