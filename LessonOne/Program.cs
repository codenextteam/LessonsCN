

//Console.Write("Hello World!");
//Console.WriteLine("Hello");


//DataType keyName = Value

//byte num1 = 255;
//sbyte numberMax = sbyte.MaxValue;
//sbyte numberMin = sbyte.MinValue;


//Console.WriteLine(numberMax);
//Console.WriteLine(numberMin);


string firstName = "Kenan";
string lastName = "Ehmedov";
short age = 17;
string nationalId = "1DF6TGD";
string phone = "+994554555656";
decimal num2 = -34.77m;
//float num3 = -45.89f;
//Console.WriteLine(num2);
//double num4 = -34.56;


//var test1 = "salam";





//bool test3 = false;
//double test4 = (int)4.5;

//bool isLogged = false;
//int ageLimit = 20;

//ControlFlow Condition
/*   switch case, if else else if */

//if (ageLimit >= 15 && ageLimit <=20)
//{
//    Console.WriteLine("ssss");
//}
//else if (ageLimit >= 20 && ageLimit <= 25)
//{
//    Console.WriteLine("ddd");
//}
//else
//{
//    Console.WriteLine("yasha uygun kontent yoxdur");
//}

bool isLogged2 = true;


//if (isLogged2)
//{
//    Console.WriteLine("xos gelmisiniz");
//    Console.WriteLine($"ad: {firstName} soyad: {lastName} " +
//    $"telefon : {phone} Fin kod : {nationalId} yash: {age}");
//}
//else
//{
//    Console.WriteLine("giris eleyin zehmet olmasa");
//}


string username = "admin";
string password = "admin123";

//Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>Admin Panele girish<<<<<<<<<<<<<<<<<<<<<<<<<");

//Console.Write("enter your username: ");
//string? setUserName = Console.ReadLine();
//Console.Write("enter your password: ");
//string? setPassword = Console.ReadLine();

//if (setUserName != "" && setPassword !="")
//{
//    if(setUserName == username && setPassword == password)
//    {
//        Console.WriteLine($"{username} xos gelmisiniz!");
//    }
//    else
//    {
//        Console.WriteLine("username ve ya password yanlisdir!");
//    }
//}
//else
//{
//    Console.WriteLine("bos gonderile bilmez!");
//}

//global scope
//short num1 = ;
//short defaultAge = short.Parse(Console.ReadLine());
//switch (defaultAge)
//{

//    //block scope
//    case < 18:
//        Console.WriteLine("cizgi filmleri");
//        break;
//    case <= 36:
//        Console.WriteLine("dram filmleri");
//        break;
//    default:
//        Console.Write("qorxu filmleri");
//        break;
//}

//loops => for, while, do while, foreach

//Console.WriteLine("front");
//Console.WriteLine("backend");
//Console.WriteLine("c#");

//for(int index)
int a = 1;
Console.WriteLine(++a);
//Console.WriteLine(a);


dynamic[] lessons = {"front",  "backend", "mobile", "full-stack", "cyber", "data science", "AI" };

for(int i = 0; i<lessons.Length; i+=1)
{
    Console.WriteLine(lessons[i]);
}
/*arithmetic    + - * / % ++ --
logical         && || !
comparison      == > < >= <= !=
assigment       = += -= %= *= /= (^ & | << >>)
*/

int g = 5;

//for (int i = 0; i < 5; i++)

//{

//    //Console.WriteLine(i);
//    //a += 1;
//    //if (i <=4)
//    //{
//    //    continue;
//    //    Console.WriteLine(i);


//    //}
//    Console.WriteLine(i+10);
//}

//while do while



int c = 11;
//while (c<10)
//{
    
//    Console.WriteLine(c);
//    c++;
//}

//do
//{
//    Console.WriteLine(c);
//    c++;
//} while(c<10);

//foreach (var item in lessons)
//{
//    Console.WriteLine(item);
//}


//classes







