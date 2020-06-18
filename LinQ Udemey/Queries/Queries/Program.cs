
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Channels;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {

            PlutoContext plutoContect = new PlutoContext();
            //   var Courses = plutoContect.Courses.Where(C => C.Name.Contains("C#")).OrderBy(S=>S.Name).ThenByDescending(C=>C.Name);//Join(Author,A=>A.AuthorId ,C=>C.)
            var Courses = plutoContect.Courses.Where(C => C.Name.Contains("C#")).OrderBy(S => S.Name).ThenByDescending(C => C.Name);//Join(Author,A=>A.AuthorId ,C=>C.)
            foreach (var course in Courses)
            {
                //Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));

                Console.WriteLine("The Course List {0}" , course.Name);
                Console.Read();
            }
        }
    }
}
