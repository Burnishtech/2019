using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamFactoryPattern
{
    interface IIceCreamFactory
    {
        string CreateIceCream();

    }
    public  class chocolateIceCream:IIceCreamFactory
    {


        public string CreateIceCream()
        {
            return "Create Chocolate IceCream";
        }
    }
    public class VanilatIceCream : IIceCreamFactory
    {


        public string CreateIceCream()
        {
           return "Create vanila IceCream";
        }
    }
    public class StrawberryIceCream : IIceCreamFactory
    {


        public string CreateIceCream()
        {
            return "Create strawberry IceCream";
        }
    }
    static class IceCreamDecider
    {
       // public static int iceCreamType;
        //public IceCreamDecider(int type)
        //{
        //    iceCreamType = type;
        //}
        public static IIceCreamFactory GetIceCreamType(int type)
        {

            switch (type)
            {
                case 0:
                    return new chocolateIceCream();
                case 1:
                    return new VanilatIceCream();
                case 2:
                    return new StrawberryIceCream();
                default:
                    return null;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {for (int i = 0; i <= 3; i++)
   {
       var type =IceCreamDecider.GetIceCreamType(i);// type = new IceCreamDecider(i);
       if (type != null)
       {
           Console.WriteLine( type.CreateIceCream());
           Console.ReadLine();
       
       
       }
   }

        }
    }
}
