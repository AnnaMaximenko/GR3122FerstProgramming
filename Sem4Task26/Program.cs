// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 26.Напишите программу, которая принимает на вход число и выдаёт количество
//цифр в числе.
//--------------------------------------------------------------------------------------------------------------------------------------


int ReadData(string line) // Чтение данных из консоли
{
    Console.WriteLine(line);//Выводим число
    int number = int.Parse(Console.ReadLine() ?? "0");  //Считываем число+проверяем на пустое занчение
    return number;//Возвращаем значение
}

int DigitCount1(int num)//Метод 1. Логарифм
{
    return (int)(Math.Log(num) + 1);
}

int DigitCount2(int num)//Метод 2. Перевод в строку.
{
    string numString = num.ToString();

    return numString.Length;
}

int DigitCount3(int num)//Метод 3. Самый быстрый
{
    int sum = 0;
    while (num > 0)
    {
        sum += 1;
        num = num / 10;
    }
    return sum;
}

void PrintResult(string line)//Выводим результат

{
    Console.WriteLine(line);//Выводим результата в линию
}

int number = ReadData("Введите число: ");//Запрос числа от пользователя

int numberofDigits = DigitCount1(number);//Вызываем метод и предаем значения

PrintResult("Количество цифр в числе: " + numberofDigits);//Вывод результата для первого метода DigitCount1


int numberofDigits2 = DigitCount2(number);//Вызываем метод и предаем значения
PrintResult("Количество цифр в числе: " + numberofDigits);//Вывод результата для первого метода DigitCount2


int numberofDigits3 = DigitCount3(number);//Вызываем метод и предаем значения
PrintResult("Количество цифр в числе: " + numberofDigits);//Вывод результата для первого метода DigitCount3
