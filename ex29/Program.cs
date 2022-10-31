// Задача 29. Написать программу вычисления произведения чисел от 1 до N

int numberN = new Random().Next(1, 10);
Console.WriteLine($"Ввод числа {numberN}");
int mult = 1;
int digit = 1;

while (digit <= numberN)
{
    mult = mult * digit;
    digit = digit + 1;
}

Console.WriteLine($"Произведение чисел от 1 до {numberN} равно {mult}");
