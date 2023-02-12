// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

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

