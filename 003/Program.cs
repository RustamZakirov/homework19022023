// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void InputMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = new Random().Next(1, 10); 
    }
}


void PrintMatrix(int[,] matr)
{  
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write($"{matr[i, j]} \t");
        Console.WriteLine();
    } 
}

 void multiplication (int[,] matrix1, int[,] matrix2, int[,] result)
 {
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int count = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                count = count + matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = count;
        }      
    }
 }


Console.Clear();
Console.Write("Введите размер 1 массива: ");
int[] size1 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size1[0], size1[1]];
Console.Write("Введите размер 2 массива: ");
int[] size2 = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix2 = new int[size2[0], size2[1]];
if (size1[1] != size2[0])
    Console.WriteLine("введите кооректно размерности массивов");
else
{
    Console.WriteLine("Матрица №1");
    InputMatrix(matrix1);
    PrintMatrix(matrix1);
    Console.WriteLine("Матрица №2");
    InputMatrix(matrix2);
    PrintMatrix(matrix2);
    int[,] result = new int[size1[0], size2[1]];
    multiplication(matrix1, matrix2, result);
    Console.WriteLine("Перемножение");
    PrintMatrix(result);
}
