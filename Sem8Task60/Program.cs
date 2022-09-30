// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
//--------------------------------------------------------------------------------------------------------------------------------------

//Считывание данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Печать трехмерного массива
void Print3DArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"{matr[i, j, k]}");
                Console.Write($"({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

//Генерация трехмерного массива
int[,,] Fill3DArray(int axisX, int axisY, int axisZ, int min, int max)
{
    int[,,] array3D = new int[axisX, axisY, axisZ];

    for (int i = 0; i < axisX; i++)
    {
        for (int j = 0; j < axisY; j++)
        {
            for (int k = 0; k < axisZ; k++)
            {
                array3D[i, j, k] = new Random().Next(min, max + 1);
            }
        }
    }
    return array3D;
}

int axisX = ReadData("Введите количество строк: ");
int axisY = ReadData("Введите количество столбцов: ");
int axisZ = ReadData("Введите количесвто слоёв: ");


Console.WriteLine();
int[,,] Matrix = Fill3DArray(axisX, axisY, axisZ, 1, 9);
Print3DArray(Matrix);

