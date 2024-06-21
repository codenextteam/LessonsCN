
using OOP4;
using OOP4.Abstract;
using OOP4.Concrete;


Student student1 = new() { Id = 1, FullName = "Elmir Mikayilli", Birthday = new DateTime(2009, 07, 23), PhoneNumber = "+99455677777" };

BaseStudentManager xAcademyStudentManager = new XAcademyStudentManager();
xAcademyStudentManager.Add(student1);

BaseStudentManager yAcademyStudentManager = new YAcademyStudentManager();

yAcademyStudentManager.Add(student1 );