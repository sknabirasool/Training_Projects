using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_LinQ_14_06
{
    public class ListManager
    {
        public static List<Person> LoadDemoData()
        {
            var output = new List<Person>();
            output.Add(new Person { FirstName="Nabi Rasool", LastName="shaik",Country="india",Old=25});
            output.Add(new Person { FirstName = "Rajesh", LastName = "MC", Country = "india", Old = 45 });
            output.Add(new Person { FirstName = "Sidda Reddy", LastName = "Konda", Country = "America", Old = 35 });
            output.Add(new Person { FirstName = "Gopi", LastName = "NAAA", Country = "china", Old = 15 });
            return output;
        }

    }
}
