using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataMangement
{
    public class Person
    {
        public string SSN;
        public string Name;
        public string Address;
        public string Age;

        public Person(string ssn,string name,string address,string age)
        {
            this.SSN = ssn;
            this.Name = name;
            this.Address = address;
            this.Age = age;
        }
    }
}
