System.Console.WriteLine("Введите любое число от 100 до 999 включительно");
int num = Convert.ToInt32(Console.ReadLine());

int result = num / 10 % 10;
System.Console.WriteLine(result);