//=============================================================
// # 4. Напишите программу, которая на вход принимает три числа и
// выдаёт, максимальное из этих чисел.
//=============================================================

string? inputLineA = Console.ReadLine(); // Ввести первое число (строка)
string? inputLineB = Console.ReadLine(); // Ввести второе число (строка)
string? inputLineC = Console.ReadLine(); // Ввести третье число (строка)

if (inputLineA != null && inputLineB != null && inputLineC != null) //проверка переменных на отсутствие значения
{
    int inputNumberA = int.Parse(inputLineA); // Переводим строку в число
    int inputNumberB = int.Parse(inputLineB); // Переводим строку в число
    int inputNumberC = int.Parse(inputLineC); // Переводим строку в число

    if (inputNumberA >= inputNumberB && inputNumberA >= inputNumberC) // Проверяем является ли число А максимальным
    {
        Console.WriteLine ("max = " + inputNumberA); // Если условие выполняется, то выводим число А
    }
    else if (inputNumberB >= inputNumberA && inputNumberB >= inputNumberC) // Проверяем является ли число В максимальным
    {
        Console.WriteLine ("max = " + inputNumberB); // Если условие выполняется, то выводим число В
    }
    else if (inputNumberC >= inputNumberA && inputNumberC >= inputNumberB) // Проверяем является ли число С максимальным
    {
        Console.WriteLine  ("max = " + inputNumberC); // Если условие выполняется, то выводим число С
    }
}
