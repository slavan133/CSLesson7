// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
// // Amn=m+n. Выведите полученный массив на экран.
// m=3; n=4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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
            int sum = i+j;
            array [i,j] = sum;
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

int [,] array2d = GetArray2d();
PrintArray2d(array2d);
