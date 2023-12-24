using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul7.HW
{
    abstract class Person<T>
    {
        private string name;
        private T dateOfBirth;

        public string Name { get { return name; } set { if (value != null) name = value; } }
        public T DateOfBirth { get { return dateOfBirth; } set { if (value != null) dateOfBirth = value; } }
    }
}
