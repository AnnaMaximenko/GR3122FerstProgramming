// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 28.Напишите программу, которая принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
//--------------------------------------------------------------------------------------------------------------------------------------

int ReadData(string line) // Чтение данных из консоли
{
    Console.WriteLine(line);//Выводим число
    int number = int.Parse(Console.ReadLine() ?? "0");  //Считываем число+проверяем на пустое занчение
    return number;//Возвращаем значение
}

long MultA(int numA)
{
    long factorial = 1;
    for (int i = 1; i <= numA; i++)
    {
        factorial = factorial * i;
    }
    return factorial;
}


void PrintResult(string line)//Выводим результат

{
    Console.WriteLine(line);//Выводим результата в линию
}

int number = ReadData("Введите число: ");
long factorial = MultA(number);
PrintResult("Факториал равен: " + factorial);