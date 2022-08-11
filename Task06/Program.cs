// Задача 6. Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трёхзначное число: ");
int n = int.Parse (Console.ReadLine());

if (n >= 100 && n < 1000)
{
    int last = n % 10;
    int first = n / 100;
    int result = last;
    Console.WriteLine("Последняя цифра трёхзначного числа: " + result);
}
else
{
    Console.WriteLine("Это не трёхзначное число");
}