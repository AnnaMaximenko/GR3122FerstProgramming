// -------------------------------------------------------------------------------------------------------------------------------------
//Задача 12.Напишите программу,которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
//Если  второе число не кратно первому, то программа выдает остаток от деления.
//--------------------------------------------------------------------------------------------------------------------------------------

///Вариант 1

void Variant1()
{
    Console.Write("Введите первое число");
    string? inputLineA = Console.ReadLine();
    Console.Write("Введите второе число");
    string? inputLineB = Console.ReadLine();
if (inputLineA != null && inputLineB != null)//Проверил не пустые ли они
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);

    Console.WriteLine((inputNumberB % inputNumberA == 0) ? ("Второе число кратно первому") : ("Остаток от деления" + inputNumberB % inputNumberA));// тернанрный оператор
}
}

Variant1();

// ///Вариант 2

// string? inputLineA = Console.ReadLine();//Считал числа
// string? inputLineB = Console.ReadLine();

// if (inputLineA != null && inputLineB != null)//Проверил не пустые ли они
// {
//     int inputNumberA = int.Parse(inputLineA);// Перевел в числа
//     int inputNumberB = int.Parse(inputLineB);

//     Console.WriteLine(inputNumberB % inputNumberA == 0 ? "Является кратным" : inputNumberB % inputNumberA);
// }

///Вариант 3. Структурированный код

// int inputNumberA = 0;// Необходимо объявить переменные перед методами, чтобы каждый метод имел достп к ним.(глобально). Тогда внутри метода их указывать не нужно
// int inputNumberB = 0;
// bool result = false; // Переменная для результата. Пока она пустая

// ReadData();
// ConculateData();
// PrintData();

// //Получаем два числа пользователя
// void ReadData()
// {
//     Console.Write("Введите первое число: ");
//     string? inputLineA = Console.ReadLine();
//     Console.Write("Введите второе число: ");
//     string? inputLineB = Console.ReadLine();

//     inputNumberA = int.Parse(inputLineA);// Если глобально переменная объявленна, то int писать неи нужно внутри метода!
//     inputNumberB = int.Parse(inputLineB);


// }
// // Определяем кратность
// void ConculateData()
// {
//     result = (inputNumberB % inputNumberA == 0);
// }
// //Выводим данные вычислений
// void PrintData()
// {
//     if (result)
//     {
//         Console.WriteLine("Второе число кратно первому");
//     }
//     else
//     {
//         Console.WriteLine("Остаток от деления: " + inputNumberB % inputNumberA);
//     }
// }



