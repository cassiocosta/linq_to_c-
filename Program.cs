using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using linq_to_c_.Infrastructure;
using linq_to_c_.Models;

var repository = new PersonRepository("infrastructure/data/data.json");
IEnumerable<Person> people = repository.GetPeople();

// All with a salary above 70
var names = people.Where(p=>p.Salary >70000);
ShowData(names);

// selecting all who live in  NY
var cityNY = people.Where(p=> p.City == "New York");
ShowData(cityNY);

//Sorting by oldest
var sortedByAgeDescending = people.OrderByDescending(p => p.Age);

ShowData(sortedByAgeDescending);


//show the list
void ShowData(IEnumerable<Person> people)
{
    
    foreach (var person in people)
    {
          Console.WriteLine($"{person.Name}, Idade: {person.Age}, Salario: {person.Salary} Cidade: {person.City}");
        
    }
    Console.WriteLine("--------------");
}

// exemple GroupBy
var groupByCity = people.GroupBy(p => p.City);
foreach (var group in groupByCity)
{
    Console.WriteLine($"City: {group.Key}");
    foreach (var person in group)
    {
        Console.WriteLine($" - {person.Name}");
    }
    Console.WriteLine("--------------");
}

// agregations
var averageAge = people.Average(p => p.Age);
Console.WriteLine($" - {averageAge}");
var totalSalary = people.Sum(p => p.Salary);
Console.WriteLine($" - {totalSalary}");
var maxSalary = people.Max(p => p.Salary);
Console.WriteLine($" - {maxSalary}");

