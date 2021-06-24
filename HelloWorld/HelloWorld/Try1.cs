using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Try1
    {
        
        public static void Method(string name)
        {
            Console.WriteLine(name + " is a great person");
        }
        public static void Something()
        {
            Try1.Method("Dias");
            Try1.Method("Branko");
            Try1.Method("Someone Else");
        }
    }
}
