// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 44. Не используя рекурсию, выведите первые N чисел Не используя рекурсию, выведите первые N чисел 
//--------------------------------------------------------------------------------------------------------------------------------------


// // Метод считывания данных пользователя
// int ReadData(string line)
// {
//     // Выводим сообщение
//     Console.Write(line);
//     // Считываем число
//     int number = int.Parse(Console.ReadLine() ?? "0");
//     // Возвращаем значение
//     return number;
// }

// // Метод, печатает одномерный массив
// void Print1DArray(int[] arr)
// {
//     string arrString = "";

//     for (int i = 0; i < arr.Length - 1; i++)
//     {
//         arrString += arr[i] + ", ";
//     }

//     arrString += arr[arr.Length - 1];
//     Console.WriteLine(arrString);
// }

// int[] Fibonacci(int number)
// {
//     int[] fibonacciArr = new int[number];
//     fibonacciArr[1] = 1;

//     for (int i = 2; i < number; i++)
//     {
//         fibonacciArr[i] = fibonacciArr[i - 2] + fibonacciArr[i - 1];
//     }

//     return fibonacciArr;
// }

// int inputNumber = ReadData("Введите длину последовательности: ");

// Console.WriteLine($"Последовательность Фибоначчи длиной {inputNumber}:");
// Print1DArray(Fibonacci(inputNumber));


// Метод считывания данных пользователя
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(string prefix, string line)
{
    Console.WriteLine(prefix + line);
}

string FibNum(int num)
{
    string res = string.Empty;
    int ferst = 0;// первое число
    int last = 1;// последнее число
    int buf = 0;// переменная для накапления чисел
    for (int i = 0; i < num; i++)
    {
        res = res + " " + ferst;
        buf = ferst + last;
        ferst = last;
        last = buf;
    }
    return res;
}

int numFib = ReadData("Введите количество чисел фибоначчи: ");
string line = FibNum(numFib);
PrintResult("Числа фибоначчи: ", line);

//PrintResult("Числа фибоначчи: ", FibNum(ReadData("Введите количество чисел фибоначчи: ")));

