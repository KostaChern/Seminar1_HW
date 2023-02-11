// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
System.Console.WriteLine(" Введите два числа: ");

string inputValue_1 = System.Console.ReadLine();
System.Console.WriteLine($" Первое число = {inputValue_1}");

string inputValue_2 = System.Console.ReadLine();
System.Console.WriteLine($" Второе число = {inputValue_2}");

int value_1 = Convert.ToInt32( inputValue_1);
int value_2 = Convert.ToInt32( inputValue_2);

if (value_1 < value_2)  System.Console.WriteLine ($"Наибольшее число = { value_2 }, Наименьшее число = { value_1 }");
if (value_1 > value_2)  System.Console.WriteLine ($"Наибольшее число = { value_1 }, Наименьшее число = { value_2 }");
if (value_1 == value_2)  System.Console.WriteLine ("Вы ввели равные числа");