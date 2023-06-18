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