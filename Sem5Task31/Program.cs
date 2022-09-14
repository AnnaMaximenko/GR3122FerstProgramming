// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 31.Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.
//--------------------------------------------------------------------------------------------------------------------------------------

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

void Print1DArr(int[] outArr)//Печатаем одномерный массив

{
    for (int i = 0; i < outArr.Length - 1; i++)//
    {
        Console.Write(outArr[i] + ", ");//Печатаем результат: "элемент массива" через запятую
    }
    Console.WriteLine(outArr[outArr.Length - 1]);//Печатаем последний элемент без запятой. Для красоты
}

int[] NegotivPositivSum(int[] arr)
{
    int[] sums = new int[2];//массив, длинной два. в первой позиции накпаливаются положительные числа, во второй отрицательные
    for (int i = 0; i < arr.Length; i++)//Заполняем массив
    {
        if (arr[i] > 0)
        {
            sums[0] += arr[i];//копим положительные числа
        }
        else
        {
            sums[1] += arr[i];//копим отрицательные числа
        }
    }
    return sums;
}

void PrintResult(string line)//Выводим результат

{
    Console.WriteLine(line);//Выводим результата в линию
}

int arrayLenght = ReadData("Введите длину массива: ");
int downBorder = ReadData("Введите нижнюю границу заполнения массива: ");
int topBorder = ReadData("Введите верхнюю границу заполнения массива: ");

int[] inputArray = FillArray(arrayLenght, downBorder, topBorder);

Print1DArr(inputArray);

int[] sumArray = NegotivPositivSum(inputArray);

PrintResult("Сумма > 0: " + sumArray[0] + " Сумма < 0: " + sumArray[1]);

Print1DArr(sumArray);