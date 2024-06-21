namespace OOP
{
    internal class Student
    {

        //method overloading
        public Student()
        {

        }
        public Student(int id)
        {

        }
        public Student(string studentId)
        {

        }
        public Student(int id, string fullName)
        {

        }
        public Student(int id, string studentId, string fullName)
        {
            Id = id;
            StudentId = studentId;
            FullName = fullName;
            //Console.WriteLine($"{id}, {studentId} , {fullName}");
        }
      
      
       
      

        public int Id { get; set; }
        public string StudentId { get; set; }
        public string FullName { get; set; }

     

    }
}
