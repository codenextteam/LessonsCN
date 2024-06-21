



string[] names = new string[] { "Murad", "Elmir", "Vasif", "Abbas" };

Array.Sort(names);
foreach (var item in names)
{
    Console.WriteLine(item);
}

int[] numbers = new int[] {12, 23, 45, 1, 99, 67 }; 
Array.Sort(numbers);

foreach (var item in numbers)
{
    Console.WriteLine(item);
}

 string[,] colors = new string[2,3] 
 {
     {"red", "blue", "green" },
     {"black", "purple", "silver" }
 };

for (int i = 0; i <= colors.GetLowerBound(0); i++)
{
    for(int a=0; a<= colors.GetLowerBound(1); a++)
    {
        Console.WriteLine(colors[i,a]);
    }
}

//Product
//ProductManager 

