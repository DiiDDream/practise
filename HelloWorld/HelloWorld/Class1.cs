using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDias
{
    class Class1
    {
        public void Func()
        {
            int i = 0;
            while (i < Count)
            {
                string s = $"{Name} - {i} - {Count}";
                Console.WriteLine(s);
                i++;
            }

            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 3; j > 0; j--)
            //    {
            //        Console.WriteLine(i + j);
            //    }
            //}
        }
        public int Count = 3;
        public string Name = "HelloDias"; 
    }
}
