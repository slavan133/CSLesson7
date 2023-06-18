// Задайте двухмерный массив. Найдите элементы, у которых оба индекса нечетные, и замените эти элементы на их квадраты
// 1 4 7 2->  1 4 7 2
// 5 9 2 3->  5 81 2 9
// 8 4 2 4->  8 4 2 4

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
    Console.WriteLine("Полученный массив:");
    return array;
}

int [,] GetArray2d2(int [,] array2d)
{
    // int[,] copy = array2d.Clone() as int[,]; можно создать копию массива с названием copy и работать с ней, но тут излишне
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j <array2d.GetLength(1); j++)
        {
            if ( i%2!=0 && j%2!=0)
            {
            array2d [i,j] *= array2d [i,j]; 
            }
        }
    }
    Console.WriteLine("Преобразованный массив:");
    return array2d;
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
int [,] array2d2 = GetArray2d2(array2d);
PrintArray2d(array2d2);
