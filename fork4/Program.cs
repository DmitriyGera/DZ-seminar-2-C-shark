Console.Write("Введите число: ");
string[] d = { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье" };
string a = "";
string srg = Console.ReadLine();
int n = int.Parse(srg);
if (n > 5) a = $". Это выходной день!";
else a = $", рабочий день.";

Console.WriteLine($"{n}-й день недели - это {d[n - 1]}{a}");