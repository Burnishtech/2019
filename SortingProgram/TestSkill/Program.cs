using System;
using System.Collections.Generic;
using System.Linq;

namespace TestSkill
{
    class Program
    {

        private static void reverse()
         {
            IList<int> InputArray = new List<int>();
            InputArray.Add(1);
            InputArray.Add(2);
            InputArray.Add(4);

            InputArray.Add(5);

            for (int x = InputArray.Count - 1; x >= 0; x--)
            {
                Console.WriteLine(InputArray[x]);
                Console.Read();
            }
        }
        static void Main(string[] args)
        {
            string[] inputArray = new string[] { "cuttack" };
            Dictionary<char, int> map1 = new Dictionary<char, int>();
            string val = "tapas";

            foreach (char c in val.ToArray())
                if (!map1.ContainsKey(c))
                    map1.Add(c, 1);
                else
                    map1[c] = map1[c] + 1;

            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (string s in inputArray)
            {
                foreach (char c in s.ToArray())
                    if (!map.ContainsKey(c))
                        map.Add(c, 1);
                    else
                        map[c] = map[c] + 1;
            }

            foreach (var mapitem in map.Keys)
            {
                Console.WriteLine($"'{mapitem}' repeats {map[mapitem]} time(s)");
            }
            Console.WriteLine("Hello World!");
            //}
            reverse();
            Console.WriteLine("Hello World!");
            
        }
    }
}
