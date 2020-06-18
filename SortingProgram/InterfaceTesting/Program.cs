using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPTS
{

    interface Interface1
    {

        int Cd
        {
            get;
            set;

        }

        int Add(int a, int b);

    }
    interface Interface2
    {

        int Add1(int a, int b);

    }
    public class Class1 : Interface1, Interface2
    {


        int Interface2.Add1(int a, int b)
        {
            return a + b;
        }

        int Interface1.Add(int a, int b)
        {
            return a - b;
        }

        public int Cd
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Interface1 o1 = new Class1();
    //        Interface2 o2 = new Class1();


    //        Console.WriteLine(o1.Add(5, 10));
    //        Console.WriteLine(o2.Add1(5, 10));
    //        Console.ReadLine();
    //    }
    //}

    //same method name in 2 interface .
    interface ITestinterface1
    {
        //ITestinterface()
        //{
        //wrong interface cant contains 
        //}
        string addTwostring(string one, string two);

    }

    interface ITestinterface2
    {
        //ITestinterface()
        //{
        //wrong interface cant contains 
        //}
        string addTwostring(string one, string two);

    }
    public class TestInterface : ITestinterface1, ITestinterface2
    {

        string ITestinterface1.addTwostring(string one, string two)
        {

            return "ITestinterface1.addTwostring ---" + one + "-----" + two;
        }

        string ITestinterface2.addTwostring(string one, string two)
        {

            return "ITestinterface2.addTwostring ---" + one + "-----" + two;
        }
    }
    class Program
    {

      //  uncomment the class to get the output.
        static void Main(string[] args)
        {
            TestInterface tst = new TestInterface();
            ITestinterface2 tobj = (ITestinterface2)tst;
            tobj.addTwostring("hello", "world");
            ITestinterface1 obj = new TestInterface();
            Console.WriteLine(obj.addTwostring("tapas", "nayak"));
            ITestinterface2 obj1 = new TestInterface();
            Console.WriteLine(obj1.addTwostring("tapas", "nayak"));
            Console.ReadLine();
        }
    }
}


