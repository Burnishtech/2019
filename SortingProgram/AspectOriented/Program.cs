using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;

using Microsoft.Practices;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.InterceptionExtension;

namespace AspectOriented
{
    class Program
    {

        //this method without Interception 
        public static int Add(int No1 ,int No2)
        {  int result = 0;
                string Parameters = string.Empty;
                string ReturnValue = string.Empty;
            try
            {
              
                Console.WriteLine("Begin Execution of try block");
                Parameters = string.Format("the value enter {0} and {1}",No1,No2);
                Console.Write(Parameters);
                System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
                stopwatch.Start();
                result = No1 + No2;
                stopwatch.Stop();
                Console.WriteLine("Time taken by {0}", stopwatch.Elapsed);

                ReturnValue = String.Format("Addition of the two nos are {0}", result);
                Console.WriteLine(ReturnValue);
                Console.WriteLine("End of execution try block");


              //  return No1 + No2;

            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Exception messages{0} and parameters{1}", ex.Message.ToString(), Parameters));

                throw;
            }
          finally
            {
                Console.WriteLine("End of the execution ");

            }
            return result;

        }




        static void Main(string[] args)

        {




            IUnityContainer containerOne = new UnityContainer();
            containerOne = Microsoft.Practices.Unity.Configuration.UnityContainerExtensions.LoadConfiguration(containerOne);
            ICalculator Calc = Microsoft.Practices.Unity.UnityContainerExtensions.Resolve<ICalculator>(containerOne);

            int Result = Calc.Add(3, 2);
            int subResult = Calc.Subtract(3, 2);
            int MulResult = Calc.Multiplication(3, 2);
            int MulDiv = Calc.Division(3, 2);
            //Add(3, 8);
            Console.ReadLine();

        }
    }
}
