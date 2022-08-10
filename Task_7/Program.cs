// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int number =int.Parse(Console.ReadLine());

int x =(number % 100 -number % 10)/10;
Console.WriteLine("Вторая цифра: " + x);
