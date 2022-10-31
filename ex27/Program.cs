// задача 27. Определить кол-во цифр в числе

int numberN = new Random().Next(1, 9999);
Console.WriteLine($"Ввод числа {numberN}");
int count = 1; 

while (numberN >= 10)
{
    numberN /= 10;
    count ++;
}

Console.WriteLine($"Количество цифр в введённом числе {count}");
