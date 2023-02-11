// Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

Console.Clear();
System.Console.WriteLine(" Введите три числа: ");

string inputValue_1 = System.Console.ReadLine();
System.Console.WriteLine($" Первое число = {inputValue_1}");

string inputValue_2 = System.Console.ReadLine();
System.Console.WriteLine($" Второе число = {inputValue_2}");

string inputValue_3 = System.Console.ReadLine();
System.Console.WriteLine($" Третье число = {inputValue_3}");


int value_1 = Convert.ToInt32( inputValue_1);
int value_2 = Convert.ToInt32( inputValue_2);
int value_3 = Convert.ToInt32( inputValue_3);

int max = value_1;

if (max < value_2)  max = value_2;
if (max < value_3)  max = value_3;

System.Console.WriteLine ($"Наибольшее число = { max }");
