// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
//--------------------------------------------------------------------------------------------------------------------------------------

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;

}

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


void Print2DArray(int[,] matr) //Печать двумерного массива
{
    for (int i = 0; i < matr.GetLength(0); i++)// Проходим все строки
    {

        for (int j = 0; j < matr.GetLength(1); j++)//Проходим все столбцы
        {
            Console.Write($"{matr[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

//  Меняем первую строку с последней местами
void Change2DArray(int[,] matr)
{
    int temp = 0;
    for (int i = 0; i < matr.GetLength(1); i++)
    {
        temp = matr[0, i];
        matr[0, i] = matr[matr.GetLength(0) - 1, i];
        matr[matr.GetLength(0) - 1, i] = temp;
    }
}



int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");


int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArray(arr2D);

Console.WriteLine();

Change2DArray(arr2D);
Print2DArray(arr2D);