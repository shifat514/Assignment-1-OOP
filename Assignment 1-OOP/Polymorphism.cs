using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{

    class MyName : Program.Polymorphism.Name
    {

    }
    class Address : Program.Polymorphism.Name
    {
        public new void PrintFullName()
        {
            Console.WriteLine(FirstName + "-" + "Rampura, Dhaka");
        }
    }

}
