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
        public new void fun2()
        {
            Console.WriteLine($"B={B}");
        }
    }
    public class TypeC : TypeB
    {
        public int C { get; set; }
        public TypeC(int _A,int _B,int _c):base(_A,_B)

        {
            C= _c;

        }
        public  new void fun1()
        {
            Console.WriteLine("I am grad chiled");
        }
        public interface Example
        {
            void DisplayInfo();
            int Calculate(int a, int b);
        }

        public class ExampleClass : Example
        {
            public void DisplayInfo()
            {
                Console.WriteLine("This is an example class implementing IExample.");
            }

            public int Calculate(int a, int b)
            {
                return a + b;
            }
        }
    }

    }
}
