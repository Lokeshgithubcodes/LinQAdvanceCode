using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataFilteringINLinq
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
            {
            new Employee { Id = 1, Name = "Lokesh", Age = 24, Salary = 32000 },
            new Employee { Id = 2, Name = "somesh", Age = 23, Salary = 32000 },
            new Employee { Id = 3, Name = "will", Age = 21, Salary = 25000 },
            new Employee { Id = 4, Name = "smith", Age = 25, Salary = 39000 },
            new Employee { Id = 5, Name = "mark", Age = 22, Salary = 22000 },

            };
            var result = emp
                .Where(employee => employee.Age < 30)
                .Select(employee => new { employee.Name, employee.Salary });



            foreach (var employee in result)
            {
                Console.WriteLine("Name: " + employee.Name + "," + " salary: " + employee.Salary);
            }

            //----Aggregate operation

            List<AggregateOperation> a = new List<AggregateOperation>()
            {
                new AggregateOperation { id = 1, aname = "Laptop", aPrice = 120000 },
                new AggregateOperation { id = 2, aname = "Smartphone", aPrice = 69900 },
                new AggregateOperation { id = 3, aname = "Tablet", aPrice = 39900 },
                new AggregateOperation { id = 4, aname = "Headphones", aPrice = 8900 },
                new AggregateOperation { id = 5, aname = "Monitor", aPrice = 29900 }
            };

            // Example: Calculate aggregate functions (sum, average, count) on the Price property  .Sum(product => product.Price);

            var totsal = a.Sum(e => e.aPrice);
            var avgPrice = a.Average(e => e.aPrice);
            int Pcount = a.Count();
            var maxprice = a.Max(e => e.aPrice);
            var minPrice = a.Min(e => e.aPrice);

            Console.WriteLine("Tot sales= " + totsal);
            Console.WriteLine("Avg price= " + avgPrice);
            Console.WriteLine("Number of products= " + Pcount);
            Console.WriteLine("Max price= " + maxprice);
            Console.WriteLine("min Price= " + minPrice);

            // Sorting and Odering

            List<SortOderStudent> s = new List<SortOderStudent>()
            {
                new SortOderStudent{sid=1, sname="lokesh", CGP=4.5},
                new SortOderStudent{sid=2, sname="smith", CGP=4.0},
                new SortOderStudent{sid=3, sname="will", CGP=4.6},
                new SortOderStudent{sid=4, sname="mark", CGP=3.6},
            };

            var CpgAscending = s.OrderBy(e => e.CGP);
            Console.WriteLine("After sorted in ascending order");

            foreach(var v in s)
            {
                Console.WriteLine("Id= "+v.sid+ "Name= "+v.sname+ " CGP "+v.CGP);
            }
            

            
        }

    }
}
