Random rnd = new Random();
int number = rnd.Next(100, 1000);
Console.WriteLine($"Число: {number} Удаление второй цифры: {number / 100}{number % 10} ");