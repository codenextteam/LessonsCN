using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class TeacherManager : IPersonManager
    {
        public void Add(Person person)
        {
            if (person.Age > 18)
            {
                Console.WriteLine("Muellim elave olundu");
            }
        }
    }
}
