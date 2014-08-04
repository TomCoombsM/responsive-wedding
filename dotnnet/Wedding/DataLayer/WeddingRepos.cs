using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class WeddingRepos
    {
        public void AddOrGetPerson(Person person)
        {
            try
            {
                WeddingContext weddingContext = new WeddingContext();
                weddingContext.Person.Add(person);
                weddingContext.SaveChanges();
            }
            catch (Exception e)
            {
                
                throw;
            }
            
        }

        public IEnumerable<Person> GetPersons()
        {
            WeddingContext weddingContext = new WeddingContext();
            return from a in weddingContext.Person
                   select a;

        }
    }
}
