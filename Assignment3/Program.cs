using Assignment3.Binding;
using Assignment3.Overriding;
using static Assignment3.Overriding.TypeC;

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

            #region More practise binding
            /*    TypeA typeA1 = new TypeC(1,2,3);
                typeA1.A = 3;
              //  typeA1.B = 1;
                //typeA1.C=1
                typeA1.fun1();
                typeA1.fun2();
              */
            #endregion

            #region interface
            Example ex = new ExampleClass();
            ex.DisplayInfo();
            int result = ex.Calculate(5, 3);
            Console.WriteLine($"Calculation Result: {result}");
            #endregion
        }
    }
}
