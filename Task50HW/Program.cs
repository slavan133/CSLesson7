// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // [1,7] -> такого числа в массиве нет

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


int [,] GetArray2d()
{
    int m = Prompt("Введите значение m");
    int n = Prompt("Введите значение n");
    int [,] array = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array [i,j] = new Random().Next(1, 10);
        }
    }
    return array;
}

void PrintArray2d(int[,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void VozvratChisla (int [,] array2d)
{
    Console.WriteLine("Введите значение массива по длине");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите значение массива по высоте");
    int n = Convert.ToInt32(Console.ReadLine());
    m-=1;
    n-=1;
    int x = array2d.GetLength(0);
    int y = array2d.GetLength(1);
    if (m > x || n > y)
    {
        Console.WriteLine(m + " " + n + " не существуют");
    }
    else
    {
        int element = array2d [m,n];
        Console.WriteLine("Значение элемента " + element);     
    }
}

int [,] array2d = GetArray2d();
PrintArray2d(array2d);
VozvratChisla(array2d);

// Console.WriteLine("Введите количество столбцов для создания двумерного массива: ");
// int columns = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество строк для создания двумерного массива: ");
// int rows = int.Parse(Console.ReadLine());
// int[,] array = FillArray(rows, columns);
// Console.WriteLine("Введите строку искомого элемента: ");
// int elRow = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите столбец искомого элемента: ");
// int elCol = int.Parse(Console.ReadLine());
// if (elRow > rows || elCol > columns)
// {
//     Console.WriteLine("Такого элемента не существует!");
// }
// else
// {
//     PrintArray(array);
//     Console.WriteLine($"Значение искомого элемента = {array[elRow, elCol]}");
// }

// int[,] FillArray(int r, int c)
// {
//     int[,] result = new int[r, c];
//     for (int i = 0; i < r; i++)
//     {
//         for (int j = 0; j < c; j++)
//         {
//             result[i, j] = new Random().Next(0, 1000);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] newArray)
// {
//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//         {
//             Console.Write($"{newArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }