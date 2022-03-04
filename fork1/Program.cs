Console.Write("Введите число => ");
string strValue = Console.ReadLine();
int n = int.Parse(strValue);

Console.WriteLine($" Вторая цифра {n / 10 % 10 } ");