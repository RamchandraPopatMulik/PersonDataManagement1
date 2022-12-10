namespace PersonDataMangement
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            PersonRepository repository = new PersonRepository();
            repository.Records(list);
            repository.RetriveDataLessThanSixty(list);
            repository.CheckingForTeenagersPerson(list);
            repository.AverageAge(list);
            //Console.WriteLine("Please Enter Name Which You Want Check :");
            //string name = Console.ReadLine();
            //repository.CheckNameOrNot(list,name);
            repository.CheckRetriveRecordsGreaterThanSixty(list);
        }
    }
}