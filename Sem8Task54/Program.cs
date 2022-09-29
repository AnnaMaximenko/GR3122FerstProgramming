// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 54.  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//--------------------------------------------------------------------------------------------------------------------------------------

//Считывание данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;

}

//Генерация двухмерного массива
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rand = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for (int i = 0; i < countRow; i++)
    {

        for (int j = 0; j < countColumn; j++)
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1);

        }

    }
    return array2D;
}

//Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

//Упорядочивание по убыванию элементов двумерного массива
int[,] UpdateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        List<int> Row = new List<int>();

        for (int j = 0; j < array.GetLength(1); j++)
        {

            Row.Add(array[i, j]);
            Row.Sort();

        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Row[(array.GetLength(1) - j - 1)];//Выполняем сортировку
        }
    }
    return array;
}


int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");


int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArray(arr2D);

Console.WriteLine();

UpdateArray(arr2D);
Print2DArray(arr2D);