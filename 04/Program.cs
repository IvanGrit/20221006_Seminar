// **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 **81** 2 **9**
// 8 4 2 4


using static System.Console;

Clear();
Write("Введите количество строк и количество столбцов массива, максимальное и минимальное значение чисел: ");
int[] data = GetArrayFromString(ReadLine());
int[,] matrix = GetMatrix(data[0], data[1], data[2], data[3]);
PrintMatrix(matrix);
int a = MainDiagonale(matrix);
WriteLine($"Сумма элементов по главной диагонали равна {a}");







int[,] GetMatrix (int rows, int columns, int minValue, int maxValue)
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultMatrix[i,j] = new Random().Next(minValue,maxValue+1);           
        }

    }
    return resultMatrix;
}

void PrintMatrix(int[,] inMatrix) 
{
    for (int i = 0; i < inMatrix.GetLength(0); i++) 
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i,j]}\t");
        }
        WriteLine();
    }
}

int [] GetArrayFromString(string input)
{
    string[] parametr = input.Split(" ", System.StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int [parametr.Length];
    for (int i = 0; i < parametr.Length; i++)
    {
        result[i] = Convert.ToInt32(parametr[i]);
    }
    return result;
}

int MainDiagonale (int[,] array)
{
    int x = array.GetLength(0) > array.GetLength(1)? array.GetLength(1): array.GetLength(0);

 //   if(x > array.GetLength(1)) x = array.GetLength(1);
    int result = 0;
    for (int i = 0; i < x; i++)
    {
        result+=array[i,i];
    }
    return result;
}