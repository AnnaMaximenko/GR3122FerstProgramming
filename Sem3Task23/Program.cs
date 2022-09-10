// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 23.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов
//чисел от 1 до N.
//--------------------------------------------------------------------------------------------------------------------------------------

int ReadData(string line) // Чтение данных из консоли
{
    Console.WriteLine(line);//Выводим число
    int number = int.Parse(Console.ReadLine() ?? "0");  //Считываем число+проверяем на пустое занчение
    return number;//Возвращаем значение
}

// string LineNumbers(int numberN)//метод, для выдачи верхней строки в таблице
// {
//     int i = 1;
//     string outLine = string.Empty;
// while (i < numberN)
//     {
//         outLine = outLine + i + "\t";
//         ++i;//увеличенеие итератора в цикле, иначе он будет работать бесконечно
//     }
//     outLine = outLine + numberN;
//     return outLine;
// }

// string LineSqr(int numberN)

// {

//     int i = 1;
//     string outLine = string.Empty;
// while (i < numberN)
//     {
//         outLine = outLine + i * i * i+ "\t";
//         ++i;//увеличенеие итератора в цикле, иначе он будет работать бесконечно
//     }
//     outLine = outLine + numberN*numberN;
//     return outine;
// }

string LineNumbers(int numberN, int pow) //метод вывода чисел от 0 до N
{
    int i = 1; // первое число
    string outLine = string.Empty;//вводим переменная результата
    while (i < numberN)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t";//Если число соответствует предыдущему условию, то выводим его + табуляция 
        ++i;//увеличенеие итератора в цикле, иначе он будет работать бесконечно
    }
    outLine = outLine + Math.Pow(numberN, pow);
    return outLine;//возвращаем переменную
}


void PrintResult(string line)//Выводим результат
{
    Console.WriteLine(line);//Выводим результата в линию
}

int num = ReadData("введите число N: ");//Запрос числа от пользователя


PrintResult(LineNumbers(num, 1));//Вывод результата для первой строки таблицы
PrintResult(LineNumbers(num, 3));//Вывод результата для второй строки таблицы