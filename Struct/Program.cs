using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    public interface demo
    {
        // no access specifier is given in interface methods (by defualt they are public)  
        double Increment();
        void DisplayValues();
    }
    public struct Student : demo
    {
        int id;
        int zipcode;
        double salary;
        public Student(int id, int zipcode, double salary)
        {
            this.id = id;
            this.zipcode = zipcode;
            this.salary = salary;
        }
        public void DisplayValues()
        {
            Console.WriteLine("ID: " + this.id.ToString());
            Console.WriteLine("Zipcode : " + this.zipcode.ToString());
            Console.WriteLine("Salary : " + this.salary.ToString());
        }
        public double Increment()
        {
            return (this.salary += 1200.00);
        }
    }
    static void Main(string[] args)
    {
        var stu = new Student(10, 201014, 1500.00);
        stu.DisplayValues();
        Console.WriteLine("Salary after increment is {0}", stu.Increment());
        Console.ReadLine();
    }
}
