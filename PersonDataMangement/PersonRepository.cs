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
            list.Add(new Person("203456876", "Ramchandra", "Revangoan","23"));
            list.Add(new Person("203456877", "Sachin", "Revangoan","45"));
            list.Add(new Person("203456878", "Mahesh", "Latur","25"));
            list.Add(new Person("203456879", "Smitha", "Vita","23"));
            list.Add(new Person("203456880", "Sandip", "Sangli","26"));
            list.Add(new Person("203456881", "Shrikant", "Kolhapur", "30"));
            list.Add(new Person("203456882", "Chetan", "Banglore","26"));
            list.Add(new Person("203456883", "Mangesh", "Tamilnadu", "20"));
            list.Add(new Person("203456884", "Madan", "Khanapur", "26"));
            Console.WriteLine(list);
        }

    }
}
