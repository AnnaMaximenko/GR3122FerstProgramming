// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 66.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
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

//Сумма натуральных элементов  от M до N
string RecMN(int numM, int numN)
{
    if (numM >= numN + 1) return " ";
    return numM + " " + RecMN(numM + 1, numN);
}

int RecSum(int numM, int numN)
{
    if (numM >= numN + 1) return 0;
    return numM + RecSum(numM + 1, numN);
}



int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
if (numM < numN)
{

    Console.WriteLine(RecMN(numM, numN));
    PrintResult("Сумма элементов: " + RecSum(numM, numN));
}
else
{
    Console.WriteLine(RecMN(numN, numM));
    PrintResult("Сумма элементов: " + RecSum(numN, numM));
}

