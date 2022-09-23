// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 46. Задайте двумерный массив размером m × n заполненный случайными целыми числами.
//--------------------------------------------------------------------------------------------------------------------------------------

int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;

}

// void PrintData(string prefix, string data)
// {
//     Console.WriteLine(prefix + data);
// }

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

// void Print2DArray(int[,] matr) //Печать двумерного массива
// {
//     for (int i = 0; i < matr.GetLength(0); i++)// Проходим все строки
//     {

//         for (int j = 0; j < matr.GetLength(1); j++)//Проходим все столбцы
//         {
//             Console.Write($"{matr[i, j]}\t ");
//         }
//         Console.WriteLine();
//     }
// }

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue,ConsoleColor.Cyan,
                                        ConsoleColor.DarkBlue,ConsoleColor.DarkCyan,ConsoleColor.DarkGray,
                                        ConsoleColor.DarkGreen,ConsoleColor.DarkMagenta,ConsoleColor.DarkRed,
                                        ConsoleColor.DarkYellow,ConsoleColor.Gray,ConsoleColor.Green,
                                        ConsoleColor.Magenta,ConsoleColor.Red,ConsoleColor.White,
                                        ConsoleColor.Yellow};// Задаем цвета



//Печать двумерного массива цветом
void Print2DArrayColored(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)// Проходим все строки
    {

        for (int j = 0; j < matr.GetLength(1); j++)//Проходим все столбцы
        {
            // Console.ForegroundColor = ConsoleColor.Blue; //Если необходим один цвет
            Console.ForegroundColor = col[new System.Random().Next(0, 16)];// Рандомный выбор цвета
            Console.Write($"{matr[i, j]}\t ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");

int[,] arr2D = Fill2DArray(row, column, 10, 99);
Print2DArrayColored(arr2D);