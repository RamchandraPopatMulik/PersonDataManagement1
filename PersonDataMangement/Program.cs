﻿namespace PersonDataMangement
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
        }
    }
}