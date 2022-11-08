// Написать программу, которая преобразует массив целых чисел в массив чисел, в котором находятся только четные числа

int[] array = { 3, 6, 9, 2, 12, 4, 8, 51};
int[] evenNumbers = {};
int evenIndex = 0;

for ( int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
     {
        evenNumbers = array[i];
        evenIndex++;
     }
}
Console.WriteLine