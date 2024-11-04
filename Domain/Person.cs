using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace linq_to_c_.Models
{
    public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string City { get; set; }
    public List<string> Hobbies { get; set; }
    public decimal Salary { get; set; }
}
}