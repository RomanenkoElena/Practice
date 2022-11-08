// 1. Иниц-ция массива (как определить сколько строк, столбцов)
// 2. Наполнение массива
// 3. Вывод массива на экран
// 4. Метод сортировки элем-тов строки

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);


void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}


void PrintArray (int[,] matrix)


{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix [i,j]} ");
        }
    Console.WriteLine();
    }
}


for (int i=0; i<matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        
    }
}
