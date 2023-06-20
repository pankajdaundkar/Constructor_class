using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property_class
{
    public class employee_class
    {
        private string name, city ;
        private int id, salary;
       
        public employee_class(string name,int id, int salary, string city = "pune")
        {
            this.name = name;
            this.city = city;
            this.id = id;
            this.salary = salary;

        }
        public string PrintEmlpoyee()
        {
          return $"employee name is {name}, id is {id},salary is {salary},city is {city}";
        }
    }
}

