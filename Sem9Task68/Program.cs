// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
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

//Функция Аккермана для двух неотрицательных чисел
int FunctionAckerman(int numberM, int numberN)
{
    if (numberM == 0)
    return numberN + 1;
  else
    if ((numberM != 0) && (numberN == 0))
      return FunctionAckerman(numberM - 1, 1);
    else
      return FunctionAckerman(numberM - 1, FunctionAckerman(numberM, numberN - 1));
}


int numberM = ReadData("Введите число m: ");
int numberN = ReadData("Введите число n: ");
PrintResult(FunctionAckerman(numberM,numberN).ToString());