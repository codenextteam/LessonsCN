
using Generics;

List<string> names2 = new List<string>();
//names.Add("Murad");
//names.Add("Kenan");
//names.Add("Elvin");

//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}

MyGenerics<string> names = new();


names.Add("Murad");
names.Add("Kamal");
names.Add("Orxan");
names.Add("Kenan");


foreach (var item in names.values)
{
    Console.WriteLine(item);
}

Dictionary<int, string> users = new Dictionary<int, string>();

users.Add(001, "Murad Musali");
users.Add(002, "Kenan Tagiyev");

foreach (var item in users)
{
    Console.WriteLine($"ID:{item.Key} FullName: {item.Value}");
}

string newUser = "Elmir Huseynli";
int chekId = 3;
string saveUser = newUser;

bool isRegister = users.TryGetValue(chekId, out newUser);

if (isRegister)
{
    Console.WriteLine($"{newUser} is already user in database");
}
else
{
    users.Add(chekId, saveUser);
    foreach (var item in users)
    {
        Console.WriteLine($"ID:{item.Key} FullName: {item.Value}");
    }
}


Console.WriteLine(MyTool.FirstName);
MyTool myTool1 = new MyTool();

MyTool.FirstName = "Murad";
Console.WriteLine(MyTool.FirstName);

MyTool.FirstName = "Ayxan";
Console.WriteLine(MyTool.FirstName);


//out ve ref keyword
//Calculate calculate = new Calculate();

//int a;
//int b = 20;

//Console.WriteLine(calculate.Plus(out a, b));
//Console.WriteLine(a);