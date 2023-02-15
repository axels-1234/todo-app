using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using TodoList.Models;

namespace TodoList.Repositories
{
    public class PeopleRepository
    {
        private static PeopleRepository instance = null;
        private static Faker faker = new Faker(locale: "sv");
        private static readonly int NumberOfPeople = 5;
        private static readonly List<PersonModel> People = new List<PersonModel>();
        private static DateTime LastupdatePeople = DateTime.MinValue;
        private static string Lorem = null;
        private static DateTime LastupdateLorem = DateTime.MinValue;
        private PeopleRepository() { }
        public static PeopleRepository Instance
        {
            get
            {
                if (instance == null)
                    instance = new PeopleRepository();
                return instance;
            }
        }

        public static List<PersonModel> GetPeople()
        {
            if ((DateTime.Now - LastupdatePeople).TotalHours >= 1)
            {
                LastupdatePeople = DateTime.Now;
                foreach (var person in People)
                    People.Remove(person);
                for (int i = 0; i < NumberOfPeople; i++)
                {
                    faker = new Faker(locale: "sv");
                    People.Add(new PersonModel
                    {
                        Birthday=faker.Person.DateOfBirth,
                        City = faker.Address.City(),
                        Address = faker.Address.StreetAddress(useFullAddress: true),
                        Email = faker.Person.Email,
                        Name = faker.Person.FullName,
                        Phone = faker.Person.Phone
                    });
                }
            }
            return People;
        }

        public static string[] GetEmail()
        {
            return GetPeople().Select(x => x.Email).ToArray();
        }

        public static string[] GetAddresses()
        {
            return GetPeople().Select(x => x.Address).ToArray();
        }

        public static string[] GetPhonenumbers()
        {
            return GetPeople().Select(x => x.Phone).ToArray();
        }

        public static int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }

        public static string GetLorem()
        {
            if ((DateTime.Now - LastupdateLorem).TotalHours >= 1)
            {
                Lorem = faker.Lorem.Paragraphs(count: 10);
                LastupdateLorem = DateTime.Now;
            }
            return Lorem;
        }
    }
}
