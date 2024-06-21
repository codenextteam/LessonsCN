using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //access Modifier => private, protected, internal, public
    public class Person
    {
        public short age;
        public int Id { get; set; }
        public string Name { get; set; }
        private short Age { get; set; }

        public void AgeControl(short ageParam)
        {
            if (ageParam>0)
            {
                Age = ageParam;
                Console.WriteLine(Age);
            }
            else
            {
                Console.WriteLine("yash sehv daxil edilib");
            }
        }
        
     
    }
    

}
