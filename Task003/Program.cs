// Задача 3. Найти максимальное из трех чисел
int a = 3;
int b = 2;
int c = 45;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("max = ");
Console.WriteLine(max);