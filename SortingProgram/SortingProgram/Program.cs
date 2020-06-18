using System;
using System.Collections.Generic;
namespace Sorting
{
    class Program
    {
        /// <summary>
        /// Unique from a Array
        /// </summary>
        private static void GetUnique()
        {
            int[] items = { 11, 7, 5, 3, 3, 7, 5 };
            int n = items.Length;
            Console.WriteLine("Unique array elements: ");

            for (int i = 0; i < n; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (items[i] == items[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine(items[i]);

                }
            }

            Console.ReadLine();

        }
        /// <summary>
        /// Revesing string
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static void Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                Console.Write(cArray[i]);
            }

        }
        /// <summary>
        /// Revering a int Array ...
        /// </summary>
        /// <param name="InputArray"></param>

        public static void Reverse(IList<int> InputArray)
        {


            for (int x = InputArray.Count - 1; x >= 0; x--)
            {
                Console.WriteLine(InputArray[x]);
                Console.Read();
            }


        }
        /// <summary>
        /// Soring a array 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static IList<int> Sort(IList<int> a)
        {

            int temp;
            // foreach(int i in a)
            for (int i = 1; i <= a.Count; i++)
                for (int j = 0; j < a.Count - i; j++)
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
            return a;

        }
        /// <summary>
        /// Print soring method
        /// </summary>
        private static void PrintSorting()
        {
            IList<int> returnSort = new List<int>();
            IList<int> intList = new List<int>();
            intList.Add(2);
            intList.Add(1);
            intList.Add(30);
            intList.Add(40);
            returnSort = Sort(intList);
            for (int X = 0; X < returnSort.Count; X++)
            {
                Console.Write(returnSort[X].ToString()+"\n");
                //Console.Read();
            }
        }

        /// <summary>
        /// Fibonacai series 
        /// </summary>
        /// <param name="len">0,+1,+2+3 +5+8</param>
        private static void FabonaciSeries(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }

        }/// <summary>
         /// factorial Mathod.. 0!=0,1!=1,2!=2;3!=6
         /// </summary>

        private static void Factorial()
        {
            int i, number, fact;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFactorial of Given Number is: " + fact);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
         //   GetUnique();
            // Reverse("text");
            //IList<int> intList = new List<int>();
            //intList.Add(2);
            //intList.Add(1);
            //intList.Add(30);
            //intList.Add(40);
            //Reverse(intList);
            // Factorial();
            // FabonaciSeries(15);
        
             PrintSorting();
            Console.Read();
        }
    }
}
