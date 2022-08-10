// Показать числа от -N до N

Console.WriteLine ("Введите число N для которого мы покажем числа -N до N: ");
int UserNumber = int.Parse(Console.ReadLine ());

int count = 1;

Console.WriteLine (" ");

while (count <= UserNumber)
{
    Console.Write (count + " ");
    Console.Write ("-" + count + " ");
    count++;
}

