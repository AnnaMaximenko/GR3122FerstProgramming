// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание, что такого элемента нет.
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

int FindElement(int row, int column, int[,] array2D)
{
    if ((row < array2D.GetLength(0)) && (column < array2D.GetLength(1)))
    {
        return array2D[row, column];
    }
    else
    {
        return -1;
    }
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}



int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");


int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArray(arr2D);

int x = ReadData("Введите номер строки ");
int y = ReadData("Введите номер столбца ");
PrintResult((FindElement(x, y, arr2D) == -1) ? "Элемента с таким индексом" + " в данном массиве нет" : ("Искомый элемент: " + FindElement(x, y, arr2D)));