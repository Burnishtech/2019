using System;
namespace Polymorphism
{
    class Program
    {
        class fIRST
        {

            public void t1()
            {

                Console.Write("hELLO WORLD");

            }
        }


        static void Main(string[] args)
        {
            A a = new B();
            B b = new B();
            C c = new C();

            a.Test(); // output --> "A::Test()"
            b.Test(); // output --> "B::Test()"
            c.Test(); // output --> "C::Test()"
            A b1 = new B();
            b1.Test();

            /// IFace.
        }
    }
    class A
    {
        public void Test() { Console.WriteLine("A::Test()"); }
    }

    class B : A
    {
        public new virtual void Test() { Console.WriteLine("B::Test()"); }
    }

    class C : B
    {
        public override void Test() { Console.WriteLine("C::Test()"); }
    }
}