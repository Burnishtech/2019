
////Working Code need to uncommnet to see teh 
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.Practices.Unity;
//using Unity;

//namespace Depndency_Injection
//{
//    interface Idal
//    {

//        void add();
//    }
//    public class SqlserverDataAcesslayer : Idal
//    {
//        public void add()
//        {
//            Console.WriteLine("Sql server data inserted ");

//        }

//    }
//    public class OracleDataAcesslayer : Idal
//    {
//        public void add()
//        {
//            Console.WriteLine("Oracle data inserted ");

//        }

//    }
//     class customer
//    {   private Idal Objdal;
//        public customer(Idal ObjdalasParameter)
//        {
//            Objdal = ObjdalasParameter;

//        }

//        /// Middle layer
//        public string CustomerName { get; set; }
     
//        //private SqlserverDataAcesslayer Obj = new SqlserverDataAcesslayer();
//        //private OracleDataAcesslayer ObjOracle = new OracleDataAcesslayer();
       
//        public void add()
//        {
//            //if (true)
//            //    Objdal = new SqlserverDataAcesslayer();
//            //else
//            //{
//            //    Objdal = new OracleDataAcesslayer();
//            //}
//            Objdal.add();

//        }

//        //Dal

//    }
//    class Program
//    {
       
      
//        // user Inter face
//        static void Main(string[] args)
//        { IUnityContainer unityContainer = new UnityContainer();
//            unityContainer.RegisterType<customer>();
//            unityContainer.RegisterType<Idal,SqlserverDataAcesslayer>();
//         //  unityContainer.RegisterType<Idal, OracleDataAcesslayer>();
//            customer cst = unityContainer.Resolve<customer>();

//          // customer cst = new customer(new SqlserverDataAcesslayer());
//            cst.add();
//            Console.ReadLine();
//        }
      
   
//    }
//}
