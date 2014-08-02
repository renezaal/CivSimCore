using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivSimCore
{
    class Person
    {
        public Person() { }
        private string _firstName;
        private string _lastName;
        private string _callName;
        private Gender _gender;

        // returns a randomized person
        public static Person getRandom()
        {
            CivCore core = CivCore.Instance;
            Person person = core.pool.getPerson();
            person._firstName = core.rand.NextDouble().ToString();
            person._lastName = core.rand.NextDouble().ToString();
            person._callName = core.rand.NextDouble().ToString();
            person._gender = core.rand.Next(1) == 1 ? Gender.MALE : Gender.FEMALE;
            return person;
        }

        // severs all references from and to this person
        internal void Sever()
        {

        }
    }

    enum Gender
    {
        MALE, FEMALE
    }
}
