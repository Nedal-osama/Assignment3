using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Binding
{
    internal class EMP
    {
        public int id {  get; set; }
        public string name { get; set; }
        public int? age { get; set; }

        public void fun1()
        {
            Console.WriteLine("I am Emplyee");
        }
        public virtual void fun2()
        {
            Console.WriteLine($"id:{id},name:{name},age:{age}");
        }
    }
}
