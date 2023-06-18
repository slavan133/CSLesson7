// Задайте двухмерный массив. Найдите сумму элементов, находящихся на главной диагонали
// (с индексами (0;0) (1;1) и тд)
// Например:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// -> Сумма элементов главной диагонали: 1+9+2=12

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

int SummaDiagonali(int [,] array2d)
{
    // int[,] copy = array2d.Clone() as int[,];
    int sumdiag = 0;
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j <array2d.GetLength(1); j++)
        {
            if ( i == j )
            {
            sumdiag+=array2d [i,j]; 
            }
        }
    }
    return sumdiag;
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
int summadiagonali = SummaDiagonali(array2d);
Console.WriteLine($"Сумма элементов диагонали:" + " " + summadiagonali);


