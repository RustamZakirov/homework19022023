// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void InputMatrix(int[,] matrix, int i, int j, int count)
{
    for (int t = 0; t < 2; t++)
    {
        while (j + t < matrix.GetLength(1) - 1)
        {
            if (matrix[i, j] == 0)
            {
            matrix[i, j] = count;
            count++;
            j++;
            }
        }
        
        while (i + t < matrix.GetLength(0) - 1)
        {
            if (matrix[i, j] == 0)
            {
        matrix[i, j] = count;
            count++;
            i++;
            }     
        }
        while (j - t > 0)
        {
            if (matrix[i, j] == 0)
            {    
            matrix[i, j] = count;
            count++;
            j--;
            }       
        }
        while (i - t > 0)
        {
            if (matrix[i, j] == 0)
            {
            matrix[i, j] = count;
            count++;
            i--;
            }
        }
        i++;
        j++;
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}


Console.Clear();
int[,] matrix = new int[4, 4];
int i = 0;
int j = 0;
int count = 1;
InputMatrix(matrix, i, j, count);
PrintMatrix(matrix);