using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class StudentManager : IPersonManager
    {
        public void Add(Person person)
        {
            if (person.Age > 6 && person.Age<=17)
            {
                Console.WriteLine("elave olundu");
            }
        }

        public void PointCheck(Student student)
        {
            if (student.GpPoint>50)
            {
                Console.WriteLine("kecdin");
            }
        }
        
       
    }
}
