// Задача 5. Показать числа от -N до N
Console.WriteLine("Введите значение N: ");
int N = int.Parse (Console.ReadLine());
int count = -N;

while (count <= N)
{
    Console.WriteLine(count);
    count = count + 1;
}