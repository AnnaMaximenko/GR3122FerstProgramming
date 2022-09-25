// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
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

double[] Count(int[,] array2D)
{
    double[] array = new double[array2D.GetLength(1)];
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array[j] = array[j] + array2D[i, j];
        }

    }
    for (int k = 0; k < array2D.GetLength(1); k++)
    {
        array[k] = array[k] / (double)array2D.GetLength(0);
    }

    return (array);
}




// Вывод массива
void Print1DArray(double[] array)
{
    Console.WriteLine("{0}", string.Join("\t", array));//Вывод массива через запятую
}


int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");


int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArray(arr2D);

Console.WriteLine("Середнее арифметическое:");

Print1DArray(Count(arr2D));//Печать массива