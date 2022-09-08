//-------------------------------------------------------------------------------------------------------------------------------------
//Напишите программу, которая выводит случайное число из отрелка [10,99] 
//и показывает наибольшую цифру этого числа.
//-------------------------------------------------------------------------------------------------------------------------------------

System.Random numberGenerator = new System.Random();

int number = numberGenerator.Next(1, 100);

Console.WriteLine(number);

int firstDigit = number / 10;
int secondDigit = number % 10;

//Вариант1
if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}

//Вариант2
Console.WriteLine((firstDigit > secondDigit) ? firstDigit : secondDigit); // тернарный оператор

// Вариант  char

char[] charArray = number.ToString().ToCharArray();
Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);

//вариант с методом

void MyVariant()

{
    Console.WriteLine("Метод 1");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(1, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;

    //Вариант1
    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }

}

void variant2()
{
    Console.WriteLine("Метод 2");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(1, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;

    Console.WriteLine((firstDigit > secondDigit) ? firstDigit : secondDigit);
}

void VariantChar()
{
    Console.WriteLine("Метод 3");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(1, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;

    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(((int)charArray[0] > (int)charArray[1]) ? charArray[0] : charArray[1]);
}

// суть метода заключается в том, что он изолирован от программы. Программе необходимо, чтобы мы его вызвали. В нашем случае:

MyVariant();
variant2();
VariantChar();