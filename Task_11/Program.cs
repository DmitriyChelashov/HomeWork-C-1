﻿// Найти третью цифру числа или сообщить, что её нет
int Number = new Random().Next(1, 2000);
System.Console.WriteLine($"Дано число: {Number}");

if (Number / 100 > 0) System.Console.WriteLine($"Третьей цифрой числа {Number} является цифра {Number / 100 % 10}");
else System.Console.WriteLine($"У числа {Number} нет третьей цифры");

System.Console.WriteLine();