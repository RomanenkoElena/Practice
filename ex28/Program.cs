// задача 28. подсчитать сумму цифр в числе

int numberN = new Random().Next(1, 9999);
Console.WriteLine($"Ввод числа {numberN}");
int sum = 0;
int digit = 0;

while (numberN > 0)
{
    digit = numberN % 10;
    sum = sum + digit;
    numberN = numberN /= 10;    
}

Console.WriteLine($"Сумма цифр в числе равна {sum}");
