using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace LinqBasic
{
	public partial class Form2 : Form
	{
    	List<Employee> employees = new List<Employee>();
    	List<Employee> employees1 = new List<Employee>();
    	List<Order> orders = new List<Order>();
    	public Form2()
    	{
        	InitializeComponent();
    	}
    	private void Form2_Load(object sender, EventArgs e)
    	{
        	employees.Add(new Employee { age = 40, name = "Basob" });
        	employees.Add(new Employee { age = 34, name = "Abhishek" });
        	employees.Add(new Employee { age = 65, name = "Souvik" });
        	employees.Add(new Employee { age = 65, name = "Ayan" });
        	employees.Add(new Employee { age = 68, name = "Raj" });
        	employees1.Add(new Employee { age = 68, name = "Pallab" });
        	employees1.Add(new Employee { age = 55, name = "Swarup" });
        	employees1.Add(new Employee { age = 68, name = "Ranjit" });
        	employees1.Add(new Employee { age = 68, name = "Bratin" });
        	orders.Add(new Order { empName = "Raj", itemName = "Pen" });
        	orders.Add(new Order { empName = "Souvik", itemName = "Pencil" });
        	orders.Add(new Order { empName = "Raj", itemName = "Rubber" });
        	listBox1.DataSource = employees;
        	
    	}
    	private void button1_Click(object sender, EventArgs e)
    	{
        	List<Employee> filteredList = new List<Employee>();
        	//var filterEnumerable = from emp in employees
        	//                   	where emp.age > 50
        	//                   	select emp;
        	var filterEnumerable = employees.Where<Employee>(emp => emp.age > 50);
        	filteredList = filterEnumerable.ToList();
        	listBox2.DataSource = filteredList;
    	}
    	private void button2_Click(object sender, EventArgs e)
    	{
        	List<Employee> filteredList = new List<Employee>();
        	//var filterEnumerable = from emp in employees
        	//                    	orderby emp.name descending
        	//                    	select emp.name;
        	var filterEnumerable = employees.Select<Employee, string>(r => r.name);
        	//filteredList = filterEnumerable.ToList();
        	listBox2.DataSource = filterEnumerable.ToList<string>();
    	}
    	private void button3_Click(object sender, EventArgs e)
    	{
        	List<Employee> filteredList = new List<Employee>();
        	var filterEnumerable = (from emp in employees
                                	select emp).Take<Employee>(2);
                               	
        	//var filterEnumerable = employees.Select<Employee, string>(r => r.name);
        	//filteredList = filterEnumerable.ToList();
        	listBox2.DataSource = filterEnumerable.ToList<Employee>();
    	}
    	private void button4_Click(object sender, EventArgs e)
    	{
        	List<Employee> filteredList = new List<Employee>();
        	//var filterEnumerable = (from emp in employees
        	//                    	select emp).SkipWhile<Employee>(r => r.name.Length > 4);
        	var filterEnumerable = employees.Select<Employee, Employee>(r => { return r; }).SkipWhile<Employee>(r => r.name.Length > 4);
        	//filteredList = filterEnumerable.ToList();
        	listBox2.DataSource = filterEnumerable.ToList<Employee>();
    	}
    	private void button5_Click(object sender, EventArgs e)
    	{
        	List<Employee> filteredList = new List<Employee>();
            //var filterEnumerable = from emp in employees
            //                   	join ord in orders on new { Name = emp.name } equals new { Name = ord.empName }
            //                   	select emp;
            var filterEnumerable = employees.Join(orders, e1 => e1.name, o => o.empName, (o, e2) => o);
        	//filteredList = filterEnumerable.ToList();
        	listBox2.DataSource = filterEnumerable.ToList<Employee>();
    	}
    	private void button6_Click(object sender, EventArgs e)
    	{
        	List<Employee> filteredList = new List<Employee>();
        	//var filterEnumerable = (from emp in employees
        	//                   	select emp).Concat<Employee>(from emp in employees1
        	//                   	select emp);
        	var filterEnumerable = employees.Concat<Employee>(employees1.AsEnumerable<Employee>());
        	//filteredList = filterEnumerable.ToList();
        	listBox2.DataSource = filterEnumerable.ToList<Employee>();
    	}
    	private void button7_Click(object sender, EventArgs e)
    	{
        	//var filterEnumerable = from emp in employees
        	//                   	group emp by emp.age into gr
        	//                   	select new { Category = gr.Key, Items = gr };
        	//listBox2.DataSource = filterEnumerable.ToList<int>();
        	var filterEnumerable2 = from emp in employees
                                	where emp.age > 65
                                	group emp by emp.age into gr
                                	where gr.Key > 40
                                	select new { aaa = gr.Key, ccc = gr.Count<Employee>(), ddd = gr.Sum<Employee>(r => r.age), bbb = gr };
        	listBox2.DataSource = (from r in filterEnumerable2 select r.aaa).ToList<int>();
        	
        	
    	}
    	private void button8_Click(object sender, EventArgs e)
    	{
        	var filterEnumerable = from emp in employees
                               	where emp.name.StartsWith("R")
                               	from ord in orders
                               	where ord.itemName.StartsWith("R")
                               	orderby ord.itemName descending
                               	select emp;
        	listBox2.DataSource = filterEnumerable.ToList<Employee>();
    	}
    	private void button9_Click(object sender, EventArgs e)
    	{
        	var filterEnumerable = employees.MyOwnWhere<Employee>(r => r.age > 25);
        	listBox2.DataSource = filterEnumerable.ToList<Employee>();
    	}
    	private void button11_Click(object sender, EventArgs e)
    	{
        	var min = employees.GetMinVal<Employee>(r => r.age);
        	listBox2.Items.Add(min.ToString());
    	}
	}
	public class Employee
	{
    	public string name;
    	public int age;
    	public override string ToString()
    	{
        	return this.name;
    	}
	}
	public class Order
	{
    	public string itemName;
    	public string empName;
    	public override string ToString()
    	{
        	return this.itemName;
    	}
	}
	public static class Extension
	{
    	public static IEnumerable<TSource> MyOwnWhere<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate) where TSource : class
    	{
        	foreach (var item in source)
        	{
            	if (predicate(item))
                	yield return item;
            	else
                	yield break;
        	}
    	}
    	public static int GetMinVal<TSource>(this IEnumerable<TSource> source,
                                	Func<TSource, int> selector)
    	{
        	int smallest = int.MaxValue;
        	foreach (var item in source)
        	{
            	int nextItem = selector(item);
            	if (nextItem < smallest)
            	{
                	smallest = nextItem;
            	}
        	}
        	return smallest;
    	}
	}
}