// Задача 8. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int n = new Random() .Next(10, 99);
Console.WriteLine(n);

int last = n % 10;
int first = n / 10 % 10;
int max = first;
if (first > max) max = first;
if (last > max) max = last;
Console.Write("max = ");
Console.WriteLine(max);