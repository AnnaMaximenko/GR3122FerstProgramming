// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 15.Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.
//--------------------------------------------------------------------------------------------------------------------------------------

Console.Write("Введите число: ");//Вводим число
string? inputLine = Console.ReadLine();
int inputDayofWeek = 0;// Переводим строку в число
string? outDayofWeeks = string.Empty;// Проверка переменной на отсутствие значения


data1();//Вызов метода

//Метод проверки цифры, обозначающей день недели, на выходной день. Вариант 1. 
void data1()
{
    if (inputLine != null)// Проверка переменной на отсутствие значения
    {
        int inputDayofWeek = int.Parse(inputLine);// Переводим строку в число
    }

    if (inputDayofWeek > 1 && inputDayofWeek < 8)// Проверка цифры на соответствие дню недели
    {
        if (inputDayofWeek == 6 || inputDayofWeek == 7)// Условие  соответствия цифры выходному дню
        {

            Console.WriteLine("Выходной");// Вывод результата
        }
        else
        {
            Console.WriteLine("Будний");// Вывод результата
        }
    }
    else
    {
        Console.WriteLine("Такого дня нет");// Вывод не соответствие дню недели
    }
}

//Метод проверки цифры, обозначающей день недели, на выходной день. Вариант 2.
// void data2()
{

    if (inputLine != null)// Проверка переменной на отсутствие значения
    {
        
        switch (inputDayofWeek)//Конструкция для сравнения нескольких значений с перемнной 
        {
            case 1: outDayofWeeks = "Понедельник"; break;
            case 2: outDayofWeeks = "Вторник"; break;
            case 3: outDayofWeeks = "Среда"; break;
            case 4: outDayofWeeks = "Четверг"; break;
            case 5: outDayofWeeks = "Пятница"; break;
            case 6: outDayofWeeks = "Суббота"; break;
            case 7: outDayofWeeks = "Воскресенье"; break;
            default: outDayofWeeks = "Такого дня нет"; break;
        }

        if (inputDayofWeek == 6 || inputDayofWeek == 7)// Условие  соответствия цифры выходному дню
        {
            Console.WriteLine("Выходной");// Вывод результата
        }
        else
        {
            Console.WriteLine("Будний");// Вывод результата
        }
    }
    else
    {
        Console.WriteLine("Такого дня нет");// Вывод не соответствие дню недели
    }
}
