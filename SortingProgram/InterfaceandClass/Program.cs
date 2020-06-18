using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceandClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 Obj = new Class1();
           
             Iinterface_1 IFace = new Class1();
            Person P = new Person();
            IDal P1 = new Person();
    //        ImplementAbstract i;
       

           /// IFace.
        }
    }

    interface Iinterface_1
    {
        void interface1_method();
    }
    class Class1 : Iinterface_1
    {
        public void Display()
        {
            Console.WriteLine("Class1 Display Method.");
        }
        //Implicit interface implementation

        //public void interface1_method()
        //{

        //    Console.WriteLine("Iinterface_1 Method.");

        //}
        //Explicit interface implementation
        void Iinterface_1.interface1_method()
        {
            Console.WriteLine("Iinterface_1 Method.");
        }

    }

     interface IDal
    {
        void Add();
        void Update();
    }

    public class Person : IDal
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void Add()
        {
            // Here goes the data access layer add code
        }

        public void Update()
        {
            // Here goes the data access layer update code
        }
    }
    abstract class absClass1
    {
        public abstract int AddTwoNumbers(int Num1, int Num2);
        public abstract int MultiplyTwoNumbers(int Num1, int Num2);
    }
   abstract class ImplementAbstract:absClass1
    {

        public abstract int AddTwoNumbers(int Num1, int Num2,int no);
    }

    class Finalimplemation : ImplementAbstract,IDal
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public override int AddTwoNumbers(int Num1, int Num2, int no)
        {
            throw new NotImplementedException();
        }

        public override int AddTwoNumbers(int Num1, int Num2)
        {
            throw new NotImplementedException();
        }

        public override int MultiplyTwoNumbers(int Num1, int Num2)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }

   
}
