using Assignment3.Binding;
using Assignment3.Overriding;

namespace Assignment3
{
   
    internal class Program
    {
        private static object typeB;
        public static void processEmp(FullTimeEmp emp)
        {
            if (emp != null)
            {
                emp.fun1();
                emp.fun2();
            }
        }
        static void Main(string[] args)
        {
          #region Overriding
            TypeA typeA = new TypeA(1);
            typeA.A = 2;

            typeA.fun1();
            typeA.fun2();

            TypeB typeB = new TypeB(1,2);
            typeB.A = 3;
            typeB.fun1();
            typeB.fun2();
            #endregion


            #region Binding 
            TypeA RefBase = new TypeB(1, 2);
            RefBase.A = 3;
            //   RefBase.B= 4;  invalid
            RefBase.fun1();
            RefBase.fun2();
            #endregion

            // TypeB typeB=(TypeB)typeA;      unsaif 

            #region nasted
            FullTimeEmp emp = new FullTimeEmp();
            emp.id = 10;
            emp.name = "Nedal";
            emp.age = 22;
            emp.salary = 50000;
            #endregion

        }
    }
}
