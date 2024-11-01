using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartesianChartSample
{
    public class PersonViewModel
    {
        public List<PersonModel> Data { get; set; }
        public PersonViewModel()
        {
            Data = new List<PersonModel>()
            {
                new PersonModel { Name = "David", Height = 170 },
                new PersonModel { Name = "Michael", Height = 96 },
                new PersonModel { Name = "Steve", Height = 65 },
                new PersonModel { Name = "Joel", Height = 182 },
                new PersonModel { Name = "Bob", Height = 134 }
            };
        }
        
    }
    public class PersonModel
    {
        public string Name { get; set; }
        public double Height { get; set; }
    }
}
