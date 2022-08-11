// Задача 10. Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите число: ");
double a = double.Parse(Console.ReadLine());
double b = 2;
double result = a / b;

if (a % b == 0)
{
    Console.WriteLine("Заданное число кратно числу b!");
}
else
{
    Console.WriteLine("Заданное число не кратно числу b!" + " Остаток = " + result);
}