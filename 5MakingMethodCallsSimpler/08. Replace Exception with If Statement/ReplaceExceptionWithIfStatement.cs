using System;
using System.Collections.Generic;

namespace MakingMethodCallsSimpler
{
    public class ReplaceExceptionWithIfStatement
    {
        public class Person
        {
            public int Id { get; set; }
        }

        public class Context
        {
            public List<Person> Persons { get; set; }
            public List<Person> Voters { get; set; }

            public int SaveChanges()
            {
                //TODO save to database
                return 0;
            }
        }

        Context _context = new Context();

        public int Save(Person person)
        {
            try
            {
                _context.Persons.Add(person);
                _context.SaveChanges();//This can throw if person.Id != -1
                _context.Voters.Add(person);
                return _context.SaveChanges();
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
