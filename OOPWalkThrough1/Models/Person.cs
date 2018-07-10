using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWalkThrough1.Models
{
    class Person
    {
        public string firstName;
        public string middleName;
        public string lastName;
        private string fullName;
   

        public string GetFullName()
        {
            fullName = firstName + " " + middleName + " " + lastName;
            return fullName;
        }

        public string GetReverseName()
        {
            char[] reversename = fullName.ToCharArray();
            Array.Reverse(reversename);
            return new string(reversename);

        }
    }
  
}
