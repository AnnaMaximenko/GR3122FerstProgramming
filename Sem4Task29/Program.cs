// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 29.Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//--------------------------------------------------------------------------------------------------------------------------------------

int ReadData(string line) // Чтение данных из консоли
{
    Console.WriteLine(line);//Выводим число
    int number = int.Parse(Console.ReadLine() ?? "0");  //Считываем число+проверяем на пустое занчение
    return number;//Возвращаем значение
}

int[] GenArr(int arrLen, int startnumber, int stopnumber)//
{
    Random rnd = new Random();//Создаем рандом
    int[] outArr = new int[arrLen];//Создаем массив
    for (int i = 0; i < arrLen; i++)//Заполняем цикл
    {
        outArr[i] = rnd.Next(startnumber, stopnumber);//Заполняем массив.Расчет.
    }
    return outArr;//Возвращаем результат (массив)
}

void PrintArr(int[] outArr)//Выводим результат массив

{
    for (int i = 0; i < outArr.Length - 1; i++)//
    {
        Console.Write(outArr[i] + ", ");//Печатаем результат: "элемент массива" через запятую
    }
    Console.WriteLine(outArr[outArr.Length - 1]);//Печатаем последний элемент без запятой. Для красоты
}

int arrayLenght = ReadData("Введите длину массива: ");//Запрос числа от пользователя
int startnumber = ReadData("Введите первое число: ");//Запрос числа от пользователя
int stopnumber = ReadData("Введите второе число: ");//Запрос числа от пользователя

int[] array = GenArr(arrayLenght, startnumber, stopnumber);//Вызываем метод и предаем значения
PrintArr(array);//Вывод результата