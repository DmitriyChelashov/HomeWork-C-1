// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Вставить трехзначное число, ");
int x=int.Parse(Console.ReadLine());
int y =(x/10)-(x%100/10)+x%10;


Console.WriteLine(y);
