using Assignment3.Overriding;

namespace Assignment3
{
    internal class Program
    {
        private static object typeB;

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
           
        }
    }
}
