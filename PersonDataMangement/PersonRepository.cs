using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataMangement
{
    public class PersonRepository
    {

        public void Records(List<Person> list )
        {
            list.Add(new Person("203456876", "Ramchandra", "Revangoan",25));
            list.Add(new Person("203456877", "Sachin", "Revangoan",56));
            list.Add(new Person("203456878", "Mahesh", "Latur",71));
            list.Add(new Person("203456879", "Smitha", "Vita",46));
            list.Add(new Person("203456880", "Sandip", "Sangli",59));
            list.Add(new Person("203456881", "Shrikant", "Kolhapur", 52));
            list.Add(new Person("203456882", "Chetan", "Banglore",53));
            list.Add(new Person("203456883", "Mangesh", "Tamilnadu", 43));
            list.Add(new Person("203456884", "Madan", "Khanapur", 15));
            Console.WriteLine(list);
        }
        public void RetriveDataLessThanSixty(List<Person> list)
        {
            foreach(Person person in list.FindAll(e=>e.Age <60).Take(2).ToList())
            {
                Console.WriteLine("Name :"+ person.Name +"\tAge :"+person.Age);
            }
        }
        public void CheckingForTeenagersPerson(List<Person> list)
        {
            if(list.Any(e=>e.Age>=13 && e.Age <19))
            {
                Console.WriteLine("Conguartions There are Teenagers in the List");
            }
            else
            {
                Console.WriteLine("Sorry There are No Teenagers in the List");
            }
        }
        public void AverageAge(List<Person> list)
        {
            Console.WriteLine("Average Age is : "+ list.Average(e=>e.Age));
        }
    }
}
