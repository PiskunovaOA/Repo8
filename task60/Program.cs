// Задача 60. Сформируйте трёхмерный массив из случайных неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например:
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

Random rnd = new Random();
int[,,] arr = new int[2,2,2];

void FillArray()
{
    for (int yIndex = 0; yIndex < arr.GetLength(0); yIndex++)
    {
        for (int xIndex = 0; xIndex < arr.GetLength(1); xIndex++)
        {
            for (int zIndex = 0; zIndex < arr.GetLength(2); zIndex++)
            {
                arr[yIndex, xIndex, zIndex] = rnd.Next(0, 10);
            }
        }
    }
}

void PrintArray()
{
    for (int yIndex = 0; yIndex < arr.GetLength(0); yIndex++)
    {
        for (int xIndex = 0; xIndex < arr.GetLength(1); xIndex++)
        {
            for (int zIndex = 0; zIndex < arr.GetLength(2); zIndex++)
            {
                Console.WriteLine($"Индекс: {yIndex},{xIndex},{zIndex} Значение: {arr[yIndex, xIndex, zIndex]}");
            }
        }
    }
}

FillArray();
PrintArray();

Console.ReadLine();