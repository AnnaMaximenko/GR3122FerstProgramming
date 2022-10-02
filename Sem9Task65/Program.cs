// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 65. Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.
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

//Все натуральные элементы в промежутке от M до N
string RecMN(int numM, int numN)
{
    if (numM >= numN + 1) return " ";
    return numM + " " + RecMN(numM + 1, numN);
}


int numM = ReadData("Введите число M: ");
int numN = ReadData("Введите число N: ");
if (numM < numN)
{

    PrintResult(RecMN(numM, numN));
}
else
{
    PrintResult(RecMN(numN, numM));
}

