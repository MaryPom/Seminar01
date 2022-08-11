// Задача 11. Найти третью цифру числа или сообщить, что её нет
int n = new Random() .Next(1, 9999);
Console.WriteLine(n);

if (n > 99 && n < 999)
{
    Console.WriteLine(n % 10);
}
else if (n > 1000)
{
    Console.WriteLine(n % 100 / 10);
}
else
{
    Console.WriteLine( "В данном числе нет третьей цифры.");
}