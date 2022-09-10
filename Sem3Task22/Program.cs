// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 22.Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов
//чисел от 1 до N.
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

// string LineNumbers(int numberN)
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
//         outLine = outLine + i * i + "\t";
//         ++i;//увеличенеие итератора в цикле, иначе он будет работать бесконечно
//     }
//     outLine = outLine + numberN*numberN;
//     return outine;
// }


string LineNumbers(int numberN, int pow)
{
    int i = 1;
    string outLine = string.Empty;
while (i < numberN)
    {
        outLine = outLine + Math.Pow (i,pow) + "\t";
        ++i;//увеличенеие итератора в цикле, иначе он будет работать бесконечно
    }
    outLine = outLine + Math.Pow(numberN,pow);
    return outLine;
}


void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("введите число N: ");


PrintResult(LineNumbers(num,1));
PrintResult(LineNumbers(num,2));