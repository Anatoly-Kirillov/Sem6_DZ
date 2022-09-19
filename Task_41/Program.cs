// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int СountPositiveNum(int total)
{
    int result = 0;
    for (int i = 1; i <= total; i++)
    {
        Console.Write($"Введите {i} число: ");
        int temp = Convert.ToInt32(Console.ReadLine());
        if (temp > 0) result++;
    }
    return result;
}

Console.Write("Количество чисел: ");
int totalNumbers = Convert.ToInt32(Console.ReadLine());
int positiveNum = СountPositiveNum(totalNumbers);
Console.WriteLine($"Вы указали {positiveNum} числа/чисел больше 0.");
