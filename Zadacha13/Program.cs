int Obr3ZnachChislo(int num)
{
    int result = 0;
    if (num > 99 && num < 1000) result = num % 10;
    if (num < 100) {
        result = num;
        System.Console.WriteLine("третьей цифры нет");
        
    }
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
System.Console.WriteLine($"Третья цифра числа {num}= {result1}");


