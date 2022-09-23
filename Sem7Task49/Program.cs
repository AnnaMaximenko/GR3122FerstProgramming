// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти 
//элементы на их квадраты.
//--------------------------------------------------------------------------------------------------------------------------------------


// int ReadData(string line)
// {
//     Console.Write(line);
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     return number;

// }


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


// int [,] UpDate2DArray(int[,] arr2D)
// {

//     for (int i = 1; i < arr2D.GetLength(0); i=i+=2)// Проходим все строки
//     {

//         for (int j = 1; j < arr2D.GetLength(1); j=j+=2)//Проходим все столбцы
//         {
//             arr2D[i, j] = arr2D[i,j]*arr2D[i,j];

//         }

//     }
//     return arr2D;
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


// int row = ReadData("Введите количество строк: ");
// int column = ReadData("Введите количество столбцов: ");

// int[,] arr2D = Fill2DArray(row, column, 1, 11);

// Print2DArray(arr2D);

// Console.WriteLine();


// Print2DArray(UpDate2DArray(arr2D));


//Вариант 2

// // Чтение данных из консоли
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

// // Печать двумерного массива
// void Print2DArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// // Заполняем массив случайными числами
// void Fill2DArray(int[,] matr, int min, int max)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = new Random().Next(min, max + 1);
//         }
//     }
// }

// // Делаем квадраты
// void Change2DArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 matr[i, j] = (int)Math.Pow(matr[i, j], 2);
//             }

//         }
//     }
// }

// int m = ReadData("Введите количество столбцов: ");
// int n = ReadData("Введите количество строк: ");
// int[,] matrix = new int[m, n];

// Fill2DArray(matrix, 10, 99);
// Print2DArray(matrix);
// Change2DArray(matrix);

// Console.WriteLine();
// Print2DArray(matrix);


//Вариант 3

// Печать 2D массива.
void Print2DArr(int[,] arr, string message = "Массив: ")
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Генерация случайного двумерного массива.
int[,] Gen2DArr(int arrLen, int arrDepth, int arrMin, int arrMax)
{
    int[,] arr = new int[arrLen, arrDepth];
    Random rnd = new Random();

    if (arrMin > arrMax)
    {
        int temp = arrMax;
        arrMax = arrMin;
        arrMin = temp;
    }

    for (int i = 0; i < arrLen; i++)
    {
        for (int j = 0; j < arrDepth; j++)
        {
            arr[i, j] = rnd.Next(arrMin, arrMax);
        }
    }
    return arr;
}

//
int[,] EvenToSquere(int[,] arr)
{
    for (int i = 1; i < arr.GetLength(0); i+=2)
    {
        for (int j = 1; j < arr.GetLength(1); j+=2)
        {
            arr[i, j] *= arr[i, j];
        }        
    }
    return arr;
}


int[,] arr = Gen2DArr(10, 15, 10, 99);
Print2DArr(arr);
Console.WriteLine();
Console.WriteLine();
Print2DArr(EvenToSquere(arr));


// int[,] arr2d_1 = new int[10, 15];
// int[,] arr2d_2 = new int[10, 15];

// arr2d_1 = (int[,])arr.Clone();
// arr2d_2 = (int[,])arr.Clone();




// DateTime d2 = DateTime.Now;
// Change2DArray(arr2d_2);
// Console.WriteLine(DateTime.Now - d2);

// DateTime d1 = DateTime.Now;
// arr2d_1 = EvenToSquere(arr2d_1);
// Console.WriteLine(DateTime.Now - d1);
// //Print2DArr(EvenToSquere(arr));
