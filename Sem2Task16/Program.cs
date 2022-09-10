﻿// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 16.Напишите программу,которая принимает на вход два числа и проверяет
//является ли одно число квадартом другого
//--------------------------------------------------------------------------------------------------------------------------------------

// Чтение данных из консоли
int ReadData(string line)
{
    //Выводим число
    Console.WriteLine(line);
    //Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0"); // ??"0" - если пользователь ничего не введет, то программа выдаст пустое значение
    //Возвращаем значение
    return number;
}

//Тест на квадрат
bool SqrTest(int ferstNum, int secondNum) //Вводим числа
{
    if (ferstNum == secondNum * secondNum)
    {
        return true; //Возвращаем значение true
    }
    else
    {
        return false;
    }
}

//Вывод данных
void PrintData(int ferstNum, int secondNum)
{
    if (SqrTest(ferstNum, secondNum))// В условном операторе обращаемся к объявленному ранее методу + передаем наши числа в метод
    {
        Console.WriteLine("Число " + ferstNum + " квадрат числа " + secondNum);
    }
    else
    {
        Console.WriteLine("Число " + ferstNum + " не квадрат числа " + secondNum);
    }
}

int num1 = ReadData("Введите число 1: "); //Получаем два числа
int num2 = ReadData("Введите число 2: ");

PrintData(num1, num2);//Предпологаем, что первое число является квадаратом второго + вызываем наши числа
PrintData(num2, num1);//Предпологаем, что второе число является квадаратом первого + вызываем наши числа