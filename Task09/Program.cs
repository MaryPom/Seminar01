// Задача 9. Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число: ");
int n = int.Parse (Console.ReadLine());

if (n >= 100 && n < 1000)
{
    int last = n % 10;
    int first = n / 100;
    int second = n / 10 % 10;
    int result = first * 10 + last;
    Console.WriteLine("Число без второй цифры: " + result);
}
else
{
    Console.WriteLine("Это не трёхзначное число");
}