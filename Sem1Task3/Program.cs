//=============================================================
// # 3. Напишите программу, которая будет
// выдавать название дня недели по заданному номеру
//=============================================================

string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputDayofWeek = int.Parse(inputLine);

    // string[] dayofWeek = new string[7];
    // dayofWeek[0] = "Понедельник";
    // dayofWeek[1] = "Вторник";
    // dayofWeek[2] = "Среда";
    // dayofWeek[3] = "Четверг";
    // dayofWeek[4] = "Пятница";
    // dayofWeek[5] = "Суббота";
    // dayofWeek[6] = "Воскресенье";

    // if (inputDayofWeek > 7 || inputDayofWeek < 1)
    // {
    //     Console.WriteLine("Такого дня нет");
    // }
    // else
    // {


    //     Console.WriteLine(dayofWeek[inputDayofWeek - 1]);
    // }
    string outDayofWeeks = string.Empty; // Пустая строка 

    switch (inputDayofWeek)
    {
        case 1: outDayofWeeks = "Понедельник"; break;
        case 2: outDayofWeeks = "Вторник"; break;
        case 3: outDayofWeeks = "Среда"; break;
        case 4: outDayofWeeks = "Четверг"; break;
        case 5: outDayofWeeks = "Пятница"; break;
        case 6: outDayofWeeks = "Суббота"; break;
        case 7: outDayofWeeks = "Воскресенье"; break;
        default: outDayofWeeks = "Такого дня нет"; break;
    }

    //outDayofWeeks = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputDayofWeek));

    Console.WriteLine(outDayofWeeks);
}
