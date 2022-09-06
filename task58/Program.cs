// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49


int[,] firstMartrix = FillArray(4, 4);
Console.WriteLine("Матрица №1:");
PrintArray(firstMartrix);
Console.WriteLine();

int[,] secondMartrix = FillArray(4, 4);
Console.WriteLine("Матрица №2:");
PrintArray(secondMartrix);
Console.WriteLine();


int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random randomElement = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomElement.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

if (firstMartrix.GetLength(1) == secondMartrix.GetLength(0))
{
int[,] matrix3 = Array(firstMartrix, secondMartrix);
Console.WriteLine("Произведение матриц:");
PrintArray(matrix3);
}


int[,] Array(int[,] matrix, int[,] matrix2)
{
    int[,] array = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix2.GetLength(1); k++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                array[i,k] += (matrix[i, j] * matrix2[j, k]);
            }
        }
    }
    return array;
}