using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new array of instructors "represents data"
            string[] instructors = { "Jay", "Paul", "Kenn", "Dave", "Auri" };

            //Set up the query
            IEnumerable<string> query = from i in instructors
                                        where i.Length == 4
                                        select i;

            // Loop through the array using the query "for each"
            foreach (string name in query)
            {
                Console.WriteLine(name);
            }

            //Example 2 "find all hired employees hired in 2016"
            IEnumerable<Employee> emlopyees = new List<Employee>()
                // Mock Data Base "Objects"
            {
                new Employee{ID=1, Name="Johnboy", HiredDate=new DateTime(2015,3,5)},
                new Employee{ID=2, Name="Voldemort", HiredDate=new DateTime(2016,6,8)},
                new Employee{ID=1, Name="Dogman", HiredDate=new DateTime(2016,2,21)},
                new Employee{ID=2, Name="Messi", HiredDate=new DateTime(2017,12,21)},
                new Employee{ID=1, Name="Lucci", HiredDate=new DateTime(2017,1,7)},
                
            };

            IEnumerable<Employee> queryTwo = from e in emlopyees
                                             where e.HiredDate.Year == 2016
                                             orderby e.Name descending
                                             select e;
            foreach (Employee employee in queryTwo)
            {
                Console.WriteLine(employee.Name);
            }
            
        }
    }
}
