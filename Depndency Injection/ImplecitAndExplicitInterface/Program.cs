using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplecitAndExplicitInterface
{
    class Program
    {
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

            public void interface1_method()
            {

                Console.WriteLine("Iinterface_1 Method Implicit interface implementation.");

            }



            //Explicit interface implementation

            void Iinterface_1.interface1_method()
            {

                Console.WriteLine("Iinterface_1 Method Explicit interface implementation.");

            }

        }

 

        static void Main(string[] args)
        {
            //Concerte conc = new Concerte();
            Class1 objClass1 = new Class1();
            objClass1.interface1_method();
            //IImpecit XX = new Concerte();
            
           
           
        }
    }
}
