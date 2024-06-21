

using OOP3;

Student student1 = new Student();
student1.Id = 1;
student1.FullName = "Feride";
student1.PhoneNumber = "+994556677676";
student1.GpPoint = 56.78;
student1.Age = 16;

Teacher teacher1 = new Teacher();
teacher1.Id = 1;
teacher1.FullName = "Murad Musali";
teacher1.PhoneNumber = "+9945555555";
teacher1.Majorty = "C#";
teacher1.Age = 30;

Lesson lesson1 = new Lesson();
lesson1.Id = 1;
lesson1.LessonName = "Flutter";



StudentManager studentManager1 = new StudentManager();
studentManager1.PointCheck(student1);
studentManager1.Add(student1);
TeacherManager teacherManager = new TeacherManager();
teacherManager.Add(teacher1);




