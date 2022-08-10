// Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int number=int.Parse(Console.ReadLine());

int x =number %10;

Console.WriteLine("Последняя цифра: " + x);
