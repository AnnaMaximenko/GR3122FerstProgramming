// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с 
//индексами (0,0); (1;1) и т.д.
//--------------------------------------------------------------------------------------------------------------------------------------

// int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)//Универсальный метод генерации двумерного массива
// {
//     System.Random rand = new System.Random();
//     int[,] array2D = new int[countRow, countColumn];// вставляем в [] строки и столбцы (указываем, что массив двумерный)

//     for (int i = 0; i < countRow; i++)// Проходим все строки
//     {

//         for (int j = 0; j < countColumn; j++)//Проходим все столбцы
//         {
//             array2D[i, j] = rand.Next(topBorder, downBorder + 1);

//         }

//     }
//     return array2D;
// }

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

// int DiagSum(int[,] arr2D)
// {

//     int sum = 0;
//     int Len = arr2D.GetLength(0) < arr2D.GetLength(1) ? (arr2D.GetLength(0)) : (arr2D.GetLength(1));
//     for (int i = 0; i < Len; i++)
//     {
//         sum = sum + arr2D[i, i];
//     }
//     return sum;
// }



// void PrintResult(string prefix, string data)
// {
//     Console.WriteLine(prefix + data);
// }


// int[,] arr = Fill2DArray(4, 4, 1, 11);
// Print2DArray(arr);
// Console.WriteLine();
// Console.WriteLine();
// PrintResult("Сумма главной диагонали: ", DiagSum(arr).ToString());


//Вариант 2

// // Метод считывания данных пользователя
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

// // Метод, печатает одномерный массив
// void Print2DArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// // Метод генерации и заполнения массива
// int[,] Fill2DArray(int rows, int cols, int numMin, int numMax)
// {
//     // Создаём массив
//     int[,] array2D = new int[rows, cols];

//     if (numMin < numMax)
//     {
//         // Заполняем массив
//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < cols; j++)
//             {
//                 array2D[i, j] = new Random().Next(numMin, numMax + 1);
//             }
//         }
//     }

//     return array2D;
// }


// // Метод, принимает массив, возвращает сумму элементов с одинаковыми индексами
// int SumEqualIndexElements(int[,] arr)
// {
//     int length = arr.GetLength(0) < arr.GetLength(1) ? arr.GetLength(0) : arr.GetLength(1);
//     int sum = 0;

//     for (int i = 0; i < length; i++)
//     {
//         sum += arr[i, i];
//     }

//     return sum;
// }

// int numMin = 10;
// int numMax = 99;
// int rows = ReadData("Введите количество строк: ");
// int cols = ReadData("Введите количество столбцов: ");

// int[,] array2D = Fill2DArray(rows, cols, numMin, numMax);

// Console.WriteLine($"Случайный массив {rows}x{cols}:");
// Print2DArray(array2D);

// Console.WriteLine($"Сумма элементов по главной диагонали: {SumEqualIndexElements(array2D)}");



//Самый медленный вариант

// Чтение данных из консоли
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Печать результата
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}
// Печать двумерного массива
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
}
// Ищем сумму диагонали
int Change2DArray(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matr[i, j];
            }

        }
    }
    return sum;
}

// Заполняем массив случайными числами
void Fill2DArray(int[,] matr, int min, int max)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
}

int m = ReadData("Введите количество столбцов: ");
int n = ReadData("Введите количество строк: ");
int[,] matrix = new int[m, n];

Fill2DArray(matrix, 1, 9);
Print2DArray(matrix);


PrintResult("Сумма главной диагонали: ", Change2DArray(matrix).ToString());
