


using LessonThree;



//instance
//Set teacher
Teacher teacherOne = new()
{
    FirstName = "Murad",
    LastName = "Musali",
    Email = "murad.musali@codenext.az",
    GroupCount = 1,
};
Teacher teacherTwo = new()
{
    FirstName = "Zaur",
    LastName = "Aliyev",
    Email = "zaur.aliyev@codenext.az",
    GroupCount = 2,
};
//teacherOne.FirstName = "Murad";
//teacherOne.LastName = "Musali";
//teacherOne.Email = "murad.musali@codenext.az";
//teacherOne.GroupCount = 3;

//Get teacher
Console.WriteLine($"ad: {teacherOne.FirstName} soyad: {teacherOne.LastName}" +
    $" email: {teacherOne.Email} qrup sayi: {teacherOne.GroupCount}");

Console.WriteLine($"ad: {teacherTwo.FirstName} soyad: {teacherTwo.LastName}" +
    $" email: {teacherTwo.Email} qrup sayi: {teacherTwo.GroupCount}");

