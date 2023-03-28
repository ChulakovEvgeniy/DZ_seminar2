int Obr3ZnachChislo(int num)
{
    int result = 0;
    if (num > 99 && num < 1000) result = num % 10;
    if (num < 100)   result = num;
    if (num > 1000)
    {
        while (num > 1000)
        {
           num = num /10;
        }
        result = num % 10;
    }
    return result;
}
System.Console.Write("Введите число = ");
int num = Convert.ToInt32(Console.ReadLine());

int result1 = Obr3ZnachChislo(num);
if (num < 100)  System.Console.WriteLine($"Число = {num} третья цифра отсутствует");
else System.Console.WriteLine($"Третья цифра числа {num} = {result1}");


