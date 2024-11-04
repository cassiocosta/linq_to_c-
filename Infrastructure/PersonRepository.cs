using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using linq_to_c_.Models;
using Newtonsoft.Json;

namespace linq_to_c_.Infrastructure
{
    public class PersonRepository
    {
        private readonly string _filePath;

        public PersonRepository(string filePath)
        {
            _filePath = filePath;
        }

        public List<Person> GetPeople()
        {
            string json = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Person>>(json) ?? new List<Person>();
        }
    }
}