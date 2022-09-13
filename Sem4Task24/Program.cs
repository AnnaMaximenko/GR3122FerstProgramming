// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 24.Напишите программу, которая принимает на вход число (А) и выдаёт
//сумму чисел от 1 до А.
//--------------------------------------------------------------------------------------------------------------------------------------

int ReadData(string line) // Чтение данных из консоли
{
    Console.WriteLine(line);//Выводим число
    int number = int.Parse(Console.ReadLine() ?? "0");  //Считываем число+проверяем на пустое занчение
    return number;//Возвращаем значение
}

int VariantSumSimple(int numA) // Метод, который возвращает результат. Внутрь вводим число
{
    int sumOfNumbers = 0;//Переменная, в которой мы накапливаем результат. Сначала она равна 0
    for (int i = 0; i <= numA; i++)//Цикл, начальное число 0, пока число  А не достигнуто делай, и увеличиваем на 1. 
    {
        sumOfNumbers += i;//Суммируем эти числа
    }
    return sumOfNumbers;// Возвращаем сумму, которая посчитана в методе.
}

void PrintResult(string line)//Выводим результат

{
    Console.WriteLine(line);//Выводим результата в линию
}

// int numberA = ReadData("введите число А: ");
// int res = VariantSumSimple(numberA);
// PrintResult("Сумма чисел от 1 до А равна: " + res); // к варанту VariantSumSimple

int VariantSumGause(int numA)
{
    int sumOfNumbers = 0;
    sumOfNumbers = ((1 + numA) * numA) / 2;
    return sumOfNumbers;
}

int numberA = ReadData("введите число А: ");
int res = VariantSumGause(numberA);

int res1 = VariantSumSimple(numberA);

PrintResult("Сумма чисел от 1 до А равна: " + res);
PrintResult("Сумма чисел от 1 до А равна: " + res1);