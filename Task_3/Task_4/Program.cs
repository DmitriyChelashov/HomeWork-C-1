// Выяснить является ли число чётным

Console.WriteLine ("Введите целое число, чтобы проверить его четность: ");
int x = int.Parse (Console.ReadLine());

if (x % 2 == 0)
{
    Console.WriteLine ("Да, число является четным!");
}
else
{
    Console.WriteLine ("Не, нифига оно не четное!");
}