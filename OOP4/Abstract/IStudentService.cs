using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Abstract
{
    internal interface IStudentService
    {

        //can-do
        void Add(Student student);
        void Update(Student student);
        void Delete(Student student);

    }
}
