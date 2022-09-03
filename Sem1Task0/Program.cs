//=============================================================
// # 0. Напишите программу, которая на вход принимает число и
// выдаёт его квадрат (число умноженное на само себя)
//=============================================================

string? inputLine = Console.ReadLine();
if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    //int outputNumber = inputNumber * inputNumber;
    int outputNumber = (int)Math.Pow(inputNumber,2);

    Console.WriteLine(outputNumber);

}
