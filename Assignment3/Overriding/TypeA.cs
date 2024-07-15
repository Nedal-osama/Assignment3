using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Overriding
{
    public class TypeA
    {
        public int A { get; set; } 
        public TypeA (int _a)
        {
            A= _a;
        }
        public   void fun1()
        {
            Console.WriteLine("I am BAse");
        }
        public void fun2()
        {
            Console.WriteLine($"Type A :{A}");
        }

    }
    public class TypeB:TypeA
    {
        public int B { get; set; }
        public TypeB(int _a ,int _b):base(_a)
        {
            B = _b;
        }
        public new void fun1()
        {
            Console.WriteLine("I am BAse");
        }
    }
}
