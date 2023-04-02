System.Console.Write("Введите число = ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 1 && num <= 5) System.Console.WriteLine("не выходной");
else if (num > 5 && num <= 7) System.Console.WriteLine("выходной");
else System.Console.WriteLine("такого дня не существует");