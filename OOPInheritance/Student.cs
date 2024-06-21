using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance
{
    //inheritance => miras alma
    internal class Student : Person
    {
        public Student()
        {
            IsMarried = true;
        }
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Majority { get; set; }
    }
}
