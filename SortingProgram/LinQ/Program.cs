using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ
{

    class student
    {
        public int id;
        public string name;
        public int standard;
        public int age;

        public static List<student> getstudents()
        {
            List<student> Students = new List<student>()
      {
         new student{id = 1, name ="ram", age = 20, standard =12},
         new student{id = 2, name ="zip", age = 18, standard =10},
         new student{id = 3, name ="any", age = 19, standard =12},
         new student{id = 4, name ="Ian", age = 18, standard =10},
         new student{id = 5, name ="john", age = 17, standard =10},
         new student{id = 6, name ="bob", age = 19, standard =12},
         new student{id = 7, name ="moni", age = 18, standard =10},
         new student{id = 8, name ="sri", age = 19, standard =12},
         new student{id = 9, name ="dummy" , age = 17, standard =10},
         new student{id = 10, name ="hon" , age = 17, standard =10},
      };
            return Students;
        }
    }

    public class Employee
    {
        public string name;
        public int age;
        // public int Areacode { get; set; }
       
    }
    public class cityInfo
    {
        public cityInfo(string name, string state)
        {
            this.CityName = name;
            this.State = state;
        }
        public string CityName
        {
            get;
            set;
        }
        public string State
        {
            get;
            set;
        }
    }

    class Program
    {

       public static List<Employee> employees = new List<Employee>();
        public static List<cityInfo> c2 = new List<cityInfo>();
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee() { age = 90, name = "tapas" };
            employees.Add(new Employee { age = 40, name = "Basob"});
            employees.Add(new Employee {age=20,name="Ramesh" });
            employees.Add(Emp1);
            employees.Add(new Employee { age = 34, name = "Abhishek" });
            employees.Add(new Employee { age = 65, name = "Souvik" });
            employees.Add(new Employee { age = 65, name = "Ayan" });
            employees.Add(new Employee { age = 68, name = "Raj" });
            
            cityInfo ci1 = new cityInfo("Bangalore", "Karnataka");
            cityInfo ci2 = new cityInfo("Mysore", "Karnataka");
            cityInfo ci3 = new cityInfo("Delhi", "Delhi");
            cityInfo ci4 = new cityInfo("Hyderabad", "Andhra");
            cityInfo ci5 = new cityInfo("Chennai", "Tamilnadu");
            c2.Add(ci1); c2.Add(ci2); c2.Add(ci3); c2.Add(ci4); c2.Add(ci5);


            List<student> studentlist = student.getstudents();
            var resultlamba = studentlist.GroupBy(stu => stu.standard).OrderBy(stu => stu.Key);
            foreach (var group in resultlamba)
            {
                Console.WriteLine("class - {0} ", group.Key);
                Console.WriteLine("{0} -- {1} -- {2} -- {3}", "ID", "NAME", "AGE", "CLASS");
                foreach (var _student in group)
                {
                    Console.WriteLine("{0} -- {1} -- {2} -- {3}", _student.id, _student.name, _student.age, _student.standard);
                }
                Console.WriteLine("---------------------------------------------");
            }
            var resultmutiplekeylambaorderbyelement = studentlist
                        .GroupBy(stu => new { stu.standard, stu.age })
                      // .OrderBy(g => g.Key.standard).ThenBy(y => y.Key.age)
                        .Select(g => new { standardkey = g.Key.standard, agekey = g.Key.age, studentobj = g.OrderBy(y => y.name) });


            var EmpObject = employees.Where(e => e.age > 40).ToList();
            foreach(var )


            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
