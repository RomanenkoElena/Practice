// Задача 25. Найти сумму чисел от 1 до А

int numberA = new Random().Next(1, 100);
Console.WriteLine($"Ввод числа {numberA}");
int sum = 0;
int digit = 1;

while (digit <= numberA)
{
    sum = sum + digit;
    digit = digit + 1;
}

Console.WriteLine($"Сумма чисел от 1 до {numberA} равна {sum}");