Console.Write("Введите число: ");
string srg = Console.ReadLine();
int N = int.Parse(srg);

if (N / 100 > 0)
Console.WriteLine($"Третьей цифрой числа {N} является цифра {N % 100 % 10}");
else Console.WriteLine($"У числа {N} нет третьей цифры");

