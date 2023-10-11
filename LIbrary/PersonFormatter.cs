using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class PersonFormatter
    {
        public static string FormatPersonInfo(Person person)
        {
            return $"Name: {person.Name}, Age: {person.Age}, Address: {person.Address}";
        }
    }
}
