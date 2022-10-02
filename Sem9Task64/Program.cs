// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 64. Задайте значения N. Напишите все натуральные числа в промежутке от N до 1. 
//--------------------------------------------------------------------------------------------------------------------------------------


//Считывание данных от пользователя
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

//Все натуральные числа в промежутке от N до 1
string LineGenRec(int numN)
{
   
    if (numN == 0) return " ";
    string outLine = numN + " " + LineGenRec(numN - 1);

    return outLine;
}


int numN = ReadData("Введите число: ");
string resultLine = LineGenRec(numN);
PrintResult(resultLine);