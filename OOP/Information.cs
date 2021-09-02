using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Information : DataAccess
    {
        public override int Count()
        {
            return 50;
        }
        public override void Connect()
        {
            Console.WriteLine("from child");
        }

        public override void cat()
        {
            throw new NotImplementedException();
        }
    }
}
