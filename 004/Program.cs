// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void InputMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(10, 100);
            }
        }

    }
}


void FindCopy(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                for (int q = 0; q < matrix.GetLength(0); q++)
                {
                    for (int w = 0; w < matrix.GetLength(1); w++)
                    {
                        for (int e = 0; e < matrix.GetLength(2); e++)
                        {
                            if (matrix[i, j, k] == matrix[q, w, e])
                            {
                                int count = 0;
                                if (i == q)
                                    count++;
                                if (j == w)
                                    count++;
                                if (k == e)
                                    count++;   
                            if (count < 3)
                            {
                                matrix[i, j, k] = new Random().Next(10, 100);
                                FindCopy(matrix);
                            }
                            }
                        }
                    }
                }
            }
        }
    }
}


void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.Write($"{matrix[i, j, k]} {(i, j, k)}\t");
            Console.WriteLine();
        }
            
        
    }
}


Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[size[0], size[1], size[2]];
InputMatrix(matrix);
FindCopy(matrix);
PrintMatrix(matrix);