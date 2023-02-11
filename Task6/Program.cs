//  Напишите программу, которая на вход принимает число и выдаёт,
//  является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введите число >");

string value = System.Console.ReadLine();
System.Console.WriteLine($"ВВЕДЕНО {value}");

int a = Convert.ToInt32(value);

if (a % 2 == 0)
{
    System.Console.WriteLine("Введеное число является ЧЕТНЫМ");
}

else
{
   System.Console.WriteLine("Введеное число является HEчетным");  
}
