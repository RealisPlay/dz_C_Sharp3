/*Задача 54: Задайте двумерный массив
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int SetNumber(string message)
{
    System.Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int rows, int columns, int minValue = 1, int maxValue = 100)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = rand.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void Regular(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
            Console.Write($"{matrix[i, l]} ");
        Console.WriteLine();
    }
}

int rows = SetNumber("rows");
int columns = SetNumber("columns");
int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);
Regular(matrix);
System.Console.WriteLine();
PrintMatrix(matrix);

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int SetNumber(string message)
{
    System.Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[,] GetMatrix(int rows, int columns, int minValue = 1, int maxValue = 100)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = rand.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void SumMatrix(int[,] matrix)
{
    if (matrix.GetLength(0)==matrix.GetLength(1))
    {
        System.Console.WriteLine("Это квадратный массив, введи прямоугльный, например: 5,4");
        return;
    }

    int[] SumString = new int[matrix.GetLength(0)];
    int min = 0;
    System.Console.Write("Суммы элементов в каждой строке: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            SumString[i] += matrix[i,l];
        }
        Console.Write($"{SumString[i]}, ");
    }

    for (int i = 0; i < SumString.Length; i++)
    {
        if (SumString[min] > SumString[i]) min = i;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {min + 1}");
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
            Console.Write($"{matrix[i, l]} ");
        Console.WriteLine();
    }
}

int rows = SetNumber("rows");
int columns = SetNumber("columns");
int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);
SumMatrix(matrix);

/*Задача 60. ...Сформируйте трёхмерный массив . Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int SetNumber(string message)
{
    System.Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,,] GetMatrix(int rows, int columns, int planes, int minValue = 1, int maxValue = 100)
{
    int[,,] matrix = new int[rows, columns, planes];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {    
            for (int k = 0; k < planes; k++)
            {
                matrix[i, l, k] = rand.Next(minValue, maxValue + 1);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.Write($"{matrix[i, l, k]}({i},{l},{k}) ");
            Console.WriteLine("");
        }
    }
}
int rows = SetNumber("rows");
int columns = SetNumber("columns");
int planes = SetNumber("planes");
int[,,] matrix = GetMatrix(rows, columns, planes);
PrintMatrix(matrix);

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7*/

int SetNumber(string message)
{
    System.Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int rows, int columns, int minValue = 1, int maxValue = 100)
{
    int[,] matrix = new int[rows, columns];

    int i = 0;
    int l = -1;

    int row = 0;
    int col = 1;

    int t = 1;
    while (t <= rows * columns)
    {
        if ((i + row >= 0 & i + row < rows) && (l + col >= 0 & l + col < columns) && matrix[i + row, l + col] == 0)
        {
            i += row;
            l += col;
            matrix[i, l] = t++;
        }
        else if (col == 1)
        {
            row = 1;
            col = 0;
        }
        else if (row == 1)
        {
            col = -1;
            row = 0;
        }
        else if (col == -1)
        {
            col = 0;
            row = -1;
        }
        else if (row == -1)
        {
            row = 0;
            col = 1;
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write($"{matrix[i, l]} ");
        }
        Console.WriteLine();
    }
}

int rows = SetNumber("rows");
int columns = SetNumber("columns");
int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);