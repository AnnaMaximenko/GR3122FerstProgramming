// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами..
//--------------------------------------------------------------------------------------------------------------------------------------

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};// Задаем цвета



int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;

}


double[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)//Универсальный метод генерации двумерного массива
{
    System.Random rand = new System.Random();
    double[,] array2D = new double[countRow, countColumn];// вставляем в [] строки и столбцы (указываем, что массив двумерный)

    for (int i = 0; i < countRow; i++)// Проходим все строки
    {

        for (int j = 0; j < countColumn; j++)//Проходим все столбцы
        {
            array2D[i, j] = rand.Next(topBorder, downBorder + 1) * rand.NextDouble();

        }

    }
    return array2D;
}



//Печать двумерного массива цветом
void Print2DArrayColored(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)// Проходим все строки
    {

        for (int j = 0; j < matr.GetLength(1); j++)//Проходим все столбцы
        {

            PrintStringColor($"{Math.Round(matr[i, j], 2)} \t");

        }

        Console.WriteLine();
    }
}


void PrintStringColor(string data)
{
    foreach (char sign in data)
    {
        Console.ForegroundColor = col[new System.Random().Next(0, 16)];// Рандомный выбор цвета
        Console.Write(sign);
        Console.ResetColor();
    }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

double[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArrayColored(arr2D);