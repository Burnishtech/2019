using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Practices;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;
//https://sarosh.wordpress.com/2013/12/14/aop-interception-with-unity/

//https://www.youtube.com/watch?v=--wBfw9iRVg
namespace AspectOriented
{
    internal class LoggingBehaviorClass:IInterceptionBehavior
    {
      //  bool IInterceptionBehavior.WillExecute => throw new NotImplementedException();

        //public bool WillExecute=true;

        public IEnumerable<Type> GetRequiredInterfaces()
        {

            IEnumerable<Type> C=null;

            return C;
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            Console.WriteLine();
            Console.WriteLine();
            string ClassMethodname = String.Format("{0}::{1}", input.MethodBase.ReflectedType.Name, input.MethodBase.Name);
            Console.WriteLine(string.Format("******before Executionn{0} method exection ********", ClassMethodname));
            Console.WriteLine(GetparameterInfo(input));
            IMethodReturn Msg;
            try
            {

                //Console.WriteLine("Begin Execution of try block");
                //Parameters = string.Format("the value enter {0} and {1}", No1, No2);
                //Console.Write(Parameters);
                System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Start();
                Msg = getNext()(input, getNext);
                stopwatch.Stop();
                Console.WriteLine("Time taken by {0}=>{1} ", ClassMethodname,  stopwatch.Elapsed);
                Console.WriteLine("Return value from method {0} is {1}", ClassMethodname, Msg.ReturnValue.ToString());
               
                Console.WriteLine("End of execution try block -- {0}", ClassMethodname);


                //  return No1 + No2;

            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Exception Block of {0} of method {1}", ClassMethodname, ex.Message.ToString()));

                throw;
            }
            finally
            {
                Console.WriteLine("End of the execution {0}", ClassMethodname);

            }
            return Msg;
        }

        private string GetparameterInfo(IMethodInvocation input)
        {
            var str = "";
            for(int i=0; i<input.Arguments.Count;i++)
            {
                str += input.Arguments.GetParameterInfo(i).Name + "--- " + input.Arguments[i] + "|";

            }
            return str;

            //throw new NotImplementedException();
        }

        public bool WillExecute
        {
            get
            {
                return true;
            }

        }


    }
}