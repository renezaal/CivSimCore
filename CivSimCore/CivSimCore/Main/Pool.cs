using CivSimCore.Relations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivSimCore
{
    class Pool
    {
        public Pool()
        {
            refillPersonPool();
            refillFamilyPool();
        }

        #region Person pool
        // fill the pool again if it is (almost) empty
        private void refillPersonPool()
        {
            if (_persons.Count > 100)
            {
                return;
            }
            for (int i = 0; i < 1000; i++)
            {
                _persons.Add(new Person());
            }
        }

        // get a person from the pool
        public Person getPerson()
        {
            Person person = null;
            if (_persons.Count > 0)
            {
                person = _persons.First();
                _persons.Remove(person);
            }
            else
            {
                // if the pool is empty, make a new person and refill the pool
                person = new Person();
                refillPersonPool();
            }
            // return the reference to the person
            return person;
        }

        // returns a person to the pool
        public void returnPerson(Person person)
        {
            // objects in a pool may not have any references to or from them exept the reference from the pool
            person.Sever();
            _persons.Add(person);
        }

        // the pool of persons
        private List<Person> _persons = new List<Person>();
        #endregion

        #region Family pool
        // fill the pool again if it is (almost) empty
        private void refillFamilyPool()
        {
            if (_families.Count > 100)
            {
                return;
            }
            for (int i = 0; i < 1000; i++)
            {
                _families.Add(new Family());
            }
        }

        // get a family from the pool
        public Family getFamily()
        {
            Family family = null;
            if (_families.Count > 0)
            {
                family = _families.First();
                _families.Remove(family);
            }
            else
            {
                // if the pool is empty, make a new family and refill the pool
                family = new Family();
                refillFamilyPool();
            }
            // return the reference to the family
            return family;
        }

        // the pool of persons
        private List<Family> _families = new List<Family>();
        #endregion
    }
}
