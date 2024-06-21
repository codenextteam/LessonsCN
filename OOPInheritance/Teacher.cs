using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance
{
    internal class Teacher : Person
    {
        public Teacher()
        {
            Person person1 = new Person();
          
            IsMarried = true;
        }

      
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string EducateField { get; set; }
      
        

    }
}
