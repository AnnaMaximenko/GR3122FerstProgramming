// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 38.Задайте массив вещественных чисел. Найдите разницу между максимальным и
//минимальным элементов массива.
//--------------------------------------------------------------------------------------------------------------------------------------

//Универсальный метод генерации и заполнения массива
double[] FillArray(int length, int topBorder, int downBorder)
{
    Random rand = new Random();//Генератор случайных чисел
    double[] array = new double[length];//Создаем массив
    double[] numbers = new double[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.NextDouble();//Заполняем массив.Расчет.
    }
    return array;//Возвращаем результат (массив)
}


//Метод уменьшения количества знаков после запятой. 
double[] RoundArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)//Условие цикла
    {
        array[i] = Math.Round(array[i], 2);//Сокращение знаков после запятой 

    }
    return array;//Возвращаем результат (массив)
}

// Вывод массива
void Print1DArray(double[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));//Вывод массива через запятую
}

// Расчёт разницы между максимальным и минимальным элементов массива.
double MaxMin(double[] array)
{
    double min = Int32.MaxValue;// Переменная для минимального значения
    double max = Int32.MinValue;// Переменная для максимального значения


    for (int i = 0; i < array.Length; i++)//Условие цикла
    {
        if (array[i] > max) max = array[i];// Поиск максимального значения
        if (array[i] < min) min = array[i];// Поиск минимального значения

    }

    return (max - min);//Возвращаем результат + расчёт разницы между максимальным и минимальным значением

}

// Вывод ответа
void PrintAnswer(double answer)
{
    Console.WriteLine("Разницу между максимальным и минимальным элементом массива. = {0}", answer);//Вывод результата
}


double[] array = FillArray(10, 5, 10);//Вводим исходные значения для массива
Print1DArray(RoundArray(array));//Печать массива
PrintAnswer(MaxMin(array));//Печать результата