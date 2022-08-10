// Найти максимальное из трех чисел

Console.WriteLine ("Введите первое число: ");
int x = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int y = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите третье число: ");
int z = int.Parse (Console.ReadLine());

int max = x;

if (y > x)
{
    max = y;
}
if (z > y)
{
    max = z;
}
if (x > z)
{
    max = x;
}

Console.WriteLine (max);
