// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] randomArray = FillArray(4, 4);
PrintArray(randomArray);
Console.WriteLine();
int[] sumArray = sumElementsRow(randomArray);
PrintOneDimensionalArray(sumArray);
Console.WriteLine();
PrintResult(sumArray, randomArray);
Console.WriteLine();


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
        }
        Console.WriteLine();
    }
}

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


void PrintOneDimensionalArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Строка {i + 1} сумма элементов в строке = {array[i]};");
    }
}

int[] sumElementsRow(int[,] array)
{
    
    
    int [] summa = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];

        }
        summa[i] = sum;
    }
    return summa;
}

void PrintResult(int[] arr, int[,] array)
{
    int indexRow = 0;
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            indexRow = i;
        } 
    }
    Console.Write($"Строка с наименьшей суммой элементов ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[indexRow, j]}");
    }

}
