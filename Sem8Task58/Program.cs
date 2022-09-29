// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 58.  Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//--------------------------------------------------------------------------------------------------------------------------------------

//Считывание данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//Генерация двухмерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)//Универсальный метод генерации двумерного массива
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];// вставляем в [] строки и столбцы (указываем, что массив двумерный)

    for (int i = 0; i < countRow; i++)// Проходим все строки
    {

        for (int j = 0; j < countColumn; j++)//Проходим все столбцы
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);

        }

    }
    return array2D;
}


//Произведение матриц
int[,] MultiplicationMatrix(int[,] firstMatr, int[,] secondMatr)
{

    int[,] resMatrix = new int[firstMatr.GetLength(0), firstMatr.GetLength(1)];

    for (int i = 0; i < firstMatr.GetLength(0); i++)
    {
        for (int j = 0; j < firstMatr.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatr.GetLength(0); k++)
            {

                resMatrix[i, j] += firstMatr[i, k] * secondMatr[k, j];//Произведение двух матриц

            }
        }
    }

    return resMatrix;
}


int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] firstMatrix = Fill2DArray(row, column, 1, 9);
Print2DArray(firstMatrix);

Console.WriteLine();

int[,] secondMatrix = Fill2DArray(row, column, 1, 9);
Print2DArray(secondMatrix);

Console.WriteLine("Произведение двух матриц: ");
Print2DArray(MultiplicationMatrix(firstMatrix, secondMatrix));
