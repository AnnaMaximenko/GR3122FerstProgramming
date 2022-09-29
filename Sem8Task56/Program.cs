// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 56.  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//--------------------------------------------------------------------------------------------------------------------------------------

//Считывание данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
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

//Поиск строки с наименьшей суммой элементов
int FindMinRow(int[,] array)
{
    int outIndexRow = 1;
    int min = int.MaxValue;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];//Сумма элементов строки
        }

        if (min > sum)
        {
            min = sum;//Минимальная сумма
            outIndexRow = i;
        }
        sum = 0;

    }

    return outIndexRow;
}

//Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}



int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] arr2D = Fill2DArray(row, column, 1, 9);
Print2DArray(arr2D);

Console.WriteLine();

PrintResult("Cтрока с наименьшей суммой элементов: " + FindMinRow(arr2D));

