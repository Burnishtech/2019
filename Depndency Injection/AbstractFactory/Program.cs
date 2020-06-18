using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
   public interface INormal
    {

        string displayNormal();

    }
   public interface IaboveNormal
    {
        string DsplayAboveNormal(); 
    }
     class ClsWagnor:INormal
    {
       public string displayNormal()
        {

            return "WoganR maruthi average car";
        }
    }
     class ClsSwift : IaboveNormal
    {



         public string DsplayAboveNormal()
        {
            return "Swift - maruthi best car";
        }
    }
     class AudiA4 : INormal
    {
         public string displayNormal()
        {
            return "AudiA4 - Audi small car";
        }

    }
     class Audiq7 : IaboveNormal
    {
         public string DsplayAboveNormal()
        {
            return "Audiq7 - Audi big car";
        }

    }
    interface Icar
    {
        INormal GetNormal();
        IaboveNormal GetAboveNormal();
    }

   public class ClsMaruti:Icar
    {

        public INormal GetNormal()
        {
            return new ClsWagnor();
        }

        public IaboveNormal GetAboveNormal()
        {
            return new ClsSwift();
        }
    }
   public class clsAudi:Icar
    {
        public INormal GetNormal()
        {
            return new AudiA4();
        }

        public IaboveNormal GetAboveNormal()
        {
            return new Audiq7();
        }

      
        
    }

    class clsDecider
    {
        public string GetCarDetails(int iCarType)
        {
            Icar ObjClient = null;
            switch (iCarType)
            {
                case 1:
                    ObjClient = new ClsMaruti();
                    break;
                case 2:
                    ObjClient = new clsAudi();
                    break;
                default:
                    ObjClient = new ClsMaruti();
                    break;
            }

            string sOutput = "Normal Car is: " + ObjClient.GetNormal().displayNormal() + ", Above Normal car is: " + ObjClient.GetAboveNormal().DsplayAboveNormal();
            return sOutput;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            clsDecider ObjDecider = new clsDecider();
            string sResult = ObjDecider.GetCarDetails(2);
            Console.WriteLine(sResult);
            Console.ReadLine();
        }

    }
}
