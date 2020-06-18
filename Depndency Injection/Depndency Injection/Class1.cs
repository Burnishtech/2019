//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.Practices.Unity;
//using Unity;


//namespace Depndency_Injection
//{
//    class Class1
//    {
//        container.RegisterType<ILog, Log>();
//        TestLog test = Container.Resolve<TestLog>();
//        ILog log = test.CreateLog("Test Name");
//    }
//    class ILog
//    {
//    }
//    public class TestLog
//    {
//        private Func<string, ILog> logFactory;

//        public TestLog(Func<string, ILog> logFactory)
//        {
//            this.logFactory = logFactory;
//        }
//        public ILog CreateLog(string name)
//        {
//            return logFactory(name);
//        }
//    }
//}
