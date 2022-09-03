//=============================================================
// # 2. Напишите программу, которая на вход принимает два числа и
// выдаёт, какое число большее, а какое меньшее.
//=============================================================

string? inputLineA = Console.ReadLine(); // Ввести первое число (строка)
string? inputLineB = Console.ReadLine(); // Ввести второе число (строка)

if (inputLineA != null && inputLineB != null) //проверка переменных на отсутствие значения
{
    int inputNumberA = int.Parse(inputLineA); // Переводим строку в число
    int inputNumberB = int.Parse(inputLineB); // Переводим строку в число
    int outResult; // Вводим переменную результата

    if (inputNumberB > inputNumberA) //Сравниваем числа
    {
        outResult = inputNumberB; // Если В больше
        Console.WriteLine("max = " + outResult); // Выводим число В, как максимальное
    }
    else
    {
        outResult = inputNumberA; // Если А больше
        Console.WriteLine("max = " + outResult); // Выводим число А, как максимальное
    }
}
