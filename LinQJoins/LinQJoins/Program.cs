// C# program to illustrate the concept 
// of inner join in Method Syntax 
using System;
using System.Linq;
using System.Collections.Generic;

// Employee details 
public class Employee1
{

    public int emp_id
    {
        get;
        set;
    }

    public string emp_name
    {
        get;
        set;
    }
    public string emp_lang
    {
        get;
        set;
    }
}

// Employee department details 
public class Depertment
{

    public int emp_id
    {
        get;
        set;
    }

    public string emp_dept
    {
        get;
        set;
    }
    public int emp_salary
    {
        get;
        set;
    }
}

class GFG
{

    // Main method 
    static public void Main()
    {ccfgsdgsd
        List<Employee1> emp = new List<Employee1>() {

            new Employee1() {emp_id = 300, emp_name = "Anu",
                                        emp_lang = "C#"},

            new Employee1() {emp_id = 301, emp_name = "Mohit",
                                            emp_lang = "C"},

            new Employee1() {emp_id = 302, emp_name = "Sona",
                                        emp_lang = "Java"},

            new Employee1() {emp_id = 303, emp_name = "Lana",
                                        emp_lang = "Java"},

            new Employee1() {emp_id = 304, emp_name = "Lion",
                                            emp_lang = "C#"},

            new Employee1() {emp_id = 305, emp_name = "Ramona",
                                            emp_lang = "Java"},

        };

        List<Depertment> Dept = new List<Depertment>() {

            new Depertment() {emp_id = 300, emp_dept = "Designing",
                                            emp_salary = 23000},

            new Depertment() {emp_id = 301, emp_dept = "Developing",
                                            emp_salary = 40000},

            new Depertment() {emp_id = 302, emp_dept = "HR",
                                    emp_salary = 50000},

            new Depertment() {emp_id = 303, emp_dept = "Designing",
                                            emp_salary = 60000},

        };

        // Query to find the name and 
        // the department of the employees 
        // Using Join Method 
        var res = emp.Join(Dept,
                            e1 => e1.emp_id,
                            e2 => e2.emp_id,
                            (e1, e2) => new {
                                EmployeeName = e1.emp_name,
                                EmployeeDepartment = e2.emp_dept
                            });

        var result = emp.SelectMany(f => Dept, (f, a) => new
        {
            Eployeename = f.emp_name,
            DepertmentName = a.emp_dept
        });

        // Display result 
        Console.WriteLine("Employee Name and their Department:");
        foreach (var val in res)
        {
            Console.WriteLine("Employee Name: {0} Department: {1}",
                        val.EmployeeName, val.EmployeeDepartment);
        }


        Console.WriteLine("Cross Join");
        Console.WriteLine("=================================");
        foreach (var val in result)
        {
            Console.WriteLine("Employee Name: {0} Department: {1}",
                        val.Eployeename, val.DepertmentName);
        }
        Console.ReadLine();
    }
}
