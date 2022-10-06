// **Задача 46:** Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

Console.WriteLine("Hello, World!");
using static System.Console;

using static System.Console;

//**Задача 46:**Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
int[,] GetMatrixArray(int rows,int columns,int minValue, int maxValue) 
{
    int[,] resultMatrix = new int[rows, columns];
    for (int i = 0; i < resultMatrix.GetLength(0); i++) 
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++) 
        {
            resultMatrix[i,j]=new Random().Next(minValue,maxValue+1);
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
            Write($"{inMatrix[i,j]} ");
        }
        WriteLine();
    }
}

int[] GetArrayFromString(string parameters)
    {
        string[] parames = parameters.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int[] parameterNum = new int[parames.Length];
        for (int i = 0; i < parameterNum.Length; i++)
        {
            parameterNum[i] = int.Parse(parames[i]);
        }
        return parameterNum;
    }


int count = 0;

do
{
    Write("Input number: ");
    if (int.Parse(ReadLine()!) > 0) count++;
    WriteLine($"Positive numbers = {count}");
    WriteLine("Continue? Yes - enter, No - any key");
} while (ReadKey().Key==ConsoleKey.Enter);

