// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число >");

string value = System.Console.ReadLine();
System.Console.WriteLine($"ЧЕТНЫЕ ЧИСЛА ОТ 1 ДО {value}:");

int max = Convert.ToInt32(value);
int N = 1;

while (N < max + 1)

    if (N % 2 == 0)
    {
        System.Console.Write($"{N},");
        N = N + 1;
    }

    else
    {
        N = N + 1;
    }

