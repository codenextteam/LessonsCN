


using OOPInheritance;


Person person = new Person();



Student student1 = new Student();
Teacher teacher1 = new Teacher();
Tutor tutor1 = new Tutor();
Director director1 = new Director();

student1.FullName = "Ayaz Memmedov";
student1.Age = 23;
student1.PhoneNumber = "+994553443232";
student1.StudentId = 2323;
student1.Majority = "Computer science";

Console.WriteLine($"student: {student1.FullName} {student1.Majority}");


tutor1.FullName = "Kenan Ehmedov";
tutor1.Age = 45;
tutor1.PhoneNumber = "+994553677777";
tutor1.TutorInGroupCount = 1;

Console.WriteLine($"tutor: {tutor1.FullName} {tutor1.TutorInGroupCount}");


teacher1.FullName = "Elmar Memmedli";
teacher1.Age = 34;
teacher1.PhoneNumber = "+99477655555";
teacher1.TeacherId = 2334;
teacher1.EducateField = "tarix muellimi";



Console.WriteLine($"teacher: {teacher1.FullName} {teacher1.EducateField}");

director1.FullName = "Vahid elmarli";
director1.Age = 56;
director1.PhoneNumber = "+994509000000";
director1.EducationDegreeName = "Elmler doktoru";


Console.WriteLine($"director; {director1.FullName} {director1.EducationDegreeName}");

Car car = new Car();







