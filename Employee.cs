using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Constructor
{
    internal class Employee
    {
        int id;
        string name;
        public Employee()
        {
            Console.WriteLine("Employee Constructor");
            id = -1;
            name = "not Given";
        }
        public void Register()
        {
            Console.WriteLine("Enter ID");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("Id : "+id);
            Console.WriteLine("Name : "+name);
        }
    }
}
