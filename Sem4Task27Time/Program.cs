// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 27*. Сделать оценку времени алгоритма через вещественные числа и строки
//--------------------------------------------------------------------------------------------------------------------------------------

int ReadData(string line) // Чтение данных из консоли
{
    Console.WriteLine(line);//Выводим число
    int number = int.Parse(Console.ReadLine() ?? "0");  //Считываем число+проверяем на пустое занчение
    return number;//Возвращаем значение
}

int SumDigit(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number = number / 10;
    }
    return (sum);
}

int SumDigit1(int number)
{
    int sum = 0;
    int rem;
    for (sum = 0; number != 0; sum += rem)
    {
        number = Math.DivRem(number, 10, out rem);
    }
    return sum;
}

int Number = ReadData("Введите число: ");

DateTime d1 = DateTime.Now;//Запрос и определение времени "сейчас"

SumDigit(Number);//Вызываем метод SumDigit

Console.WriteLine(DateTime.Now - d1);//Вывод и расчет времени для метода SumDigit

DateTime d2 = DateTime.Now;//Запрос и определение времени "сейчас"

SumDigit1(Number);//Вызываем метод SumDigit1

Console.WriteLine(DateTime.Now - d2);//Вывод и расчет времени для метода SumDigit1




