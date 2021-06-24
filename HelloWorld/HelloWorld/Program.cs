using System;
using HelloDias;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                Try2.Method(
                    Convert.ToInt32(Console.ReadLine()),
                    Convert.ToInt32(Console.ReadLine())
                )
            );
        }

        
        //{
        //    Class1 obj = new Class1();
        //    obj.Name = "HelloDias"; 
        //    obj.Count = 4;
        //    obj.Func();
        //
        //    Class1 obj2 = new Class1();
        //    obj2.Name = "HelloBranko";
        //    obj.Count = 3;
        //    obj2.Func();
        //}







    }

}
