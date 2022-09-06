// Задача 54. Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.WriteLine("Введите число строк массива m:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов массива n:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [m,n];

FillRndArray(matrix);
PrintArray(matrix);


void PrintArray (int[,] matr)

{
for (int i = 0; i < matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
    Console.Write($"{matr[i, j]} ");
    }
Console.WriteLine();
}

}
void FillRndArray(int[,] matr)

{
for (int i = 0; i < matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
    Random rand = new Random();
    matr[i, j] = rand.Next(1, 10);
}
}

SortArray(matrix);
int[,] SortArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int k = 0; k < matr.GetLength(1); k++)
        {
            for (int j = 0; j < matr.GetLength(1) - 1; j++)
            {
                int max = matr[0, 0];
                int temp = 0;
                if (matr[i, j] < matr[i, j + 1])
                {
                    temp = matr[i, j];
                    matr[i, j] = matr[i, j + 1];
                    matr[i, j + 1] = temp;
                }
            }
        }
    }
    return matr;
}
Console.WriteLine($"Отсортированный массив: ");
}