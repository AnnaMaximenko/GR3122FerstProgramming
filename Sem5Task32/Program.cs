// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 32.Напишите программу замена элементов массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот.
//--------------------------------------------------------------------------------------------------------------------------------------

// Вариант 1


int ReadData(string line) // Чтение данных из консоли
{
    Console.WriteLine(line);//Выводим число
    int number = int.Parse(Console.ReadLine() ?? "0");  //Считываем число+проверяем на пустое занчение
    return number;//Возвращаем значение
}

int[] FillArray(int num, int downBorder, int topBorder)//Универсальный метод генерации и заполнения массива
{
    Random numSintezator = new Random();//Генератор случайных чисел
    int[] arr = new int[num];//Создаем массив

    //Тест границ.Если downBorder>topBorder программа выдаст пустой массив
    if (downBorder < topBorder)
    {
        for (int i = 0; i < arr.Length; i++)//Заполняем массив
        {
            arr[i] = numSintezator.Next(downBorder, topBorder + 1);//Заполняем массив.Расчет.
        }

    }
    return arr;//Возвращаем результат (массив)
}

void PrintArr(int[] arr)//Выводим результат массив

{
    Console.Write("[" + arr[0] + ",");
    for (int i = 1; i < arr.Length - 1; i++)//
    {
        Console.Write(arr[i] + ", ");//Печатаем результат: "элемент массива" через запятую
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");//Печатаем последний элемент без запятой. Для красоты
    Console.WriteLine();
}

int[] ReversArr(int[] arr)
{
    for (int i = 1; i < arr.Length - 1; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}

int arrayLenght = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите нижнюю границу заполнения массива: ");
int topBorder = ReadData("Введите верхнюю границу заполнения массива: ");

int[] inputArray = FillArray(arrayLenght, downBorder, topBorder);

PrintArr(inputArray);
PrintArr(ReversArr(inputArray));



// вариант 2

// // Генерация случайного массива.
// int[] GenArr(int arrLen, int arrMin, int arrMax)
// {
//     int[] arr = new int[arrLen];
//     Random rnd = new Random();

//     if (arrMin > arrMax)
//     {
//         int temp = arrMax;
//         arrMax = arrMin;
//         arrMin = temp;
//     }

//     for (int i = 0; i < arrLen; i++)
//     {
//         arr[i] = rnd.Next(arrMin, arrMax);
//     }
//     return arr;
// }

// // Печать массива
// void PrintArr(int[] arr)
// {
//     Console.WriteLine($"Массив: [{string.Join(", ", arr)}]");
// }

// int[] ReversArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] *= -1;
//     }
//     return arr;
// }

// int[] arr = GenArr(10, 5, -5);
// PrintArr(arr);

// int[] res = ReversArr(arr);
// PrintArr(res);