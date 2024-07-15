using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Binding
{
    internal class FullTimeEmp :EMP
    {
        public decimal salary {  get; set; }
        public new void fun1()
        {
            Console.WriteLine("I am fullEmplyee");
        }
        public override void fun2()
        {
            Console.WriteLine($"id:{id},name:{name},age:{age} , Salary {salary}");
        }
    }
}
