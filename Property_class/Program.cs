using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Property_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //product pro1 = new product();
            //pro1.Name = "mobile";
            //pro1.Code = 123;
            //pro1.Price = 10000;

            //Console.WriteLine($"product is {pro1.Name} code is {pro1.Code} price is {pro1.Price}");

            //product pro2 = new product() { Name = "mobile", Code = 123, Price = 10000 };

            //Console.WriteLine($"name is {pro2.Name}, code {pro2.Code},price {pro2.Price}");

            // using optional parameter

            employee_class emp1 = new employee_class("pankaj", 123, 20000);
            
            //using explicit value override value

            employee_class emp2 = new employee_class("pankaj", 123, 20000, "mumbai");

            //named arrgument 
            employee_class emp3 = new employee_class(name: "pankaj", id: 123, salary: 20000, city: "pune");

            Console.WriteLine(emp1.PrintEmlpoyee());
            Console.WriteLine(emp2.PrintEmlpoyee());
            Console.WriteLine(emp3.PrintEmlpoyee());
        }

        

        
    }   
    
    
	
}
