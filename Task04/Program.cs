﻿// Задача 4. Выяснить является ли число чётным
Console.WriteLine("Введите число: ");
int a = int.Parse (Console.ReadLine());
if (a%2 == 0)
{
    Console.WriteLine("Данное число является четным!");
}
else
{
Console.WriteLine("Данное число не является четным!");
}