using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Try2
    {
        public static int i = 11;
        public static int Method(int x, int y)
        {
            return x + y;
        }
        
        public static void Something()
        {
            int z = Method(6, 4);
            Console.WriteLine(z + i);
        }
    }   
}
