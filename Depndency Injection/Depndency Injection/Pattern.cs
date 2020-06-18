//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Depndency_Injection
//{
//   public class Pattern
//    {
       
//        static void Main(string[]  args)
//        {
//            Customer Cust = new Customer(new SqlServerDal());
//            Cust.Add();
//           Console.Write("Print the test result");
//            Console.ReadLine();
//        public class Customer
//        {
//            private DataAcessLayer Idal;
//            //private SqlServerDal ObjSqlserver = new SqlServerDal();
//           // private OracleDataAcess ObjOracleServer = new OracleDataAcess();
//            public string Name { get; set; }
//            public Customer(DataAcessLayer Idallayer)
//            {
//                Idal = Idallayer;

//            }
//            public void Add()
//            {
//                //if (true){
//                //    Idal= new SqlServerDal();
                    
//                //}
//                //else
//                //{
//                //    Idal = new OracleDataAcess();
                   
//                //} 
                
//                Idal.Add();
//            }
//        }
//       interface DataAcessLayer
//       {
//           void Add();
//       }
//        public class OracleDataAcess:DataAcessLayer
//        {

//            public void Add()
//            {

//                Console.WriteLine("Sql server Data Acess layer Called ;");
//            }
//        }

//        public class SqlServerDal : DataAcessLayer
//        {

//            public void Add()
//            {

//                Console.WriteLine("Sql server Data Acess layer Called ;");
//            }
//        }
//    }
//}
