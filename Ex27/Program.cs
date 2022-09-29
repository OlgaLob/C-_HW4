// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// Ограничения:
// - Должна быть отдельная функция, которая возвразает результат суммы цифр
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

int Summator(int num)
{
    int result = 0;

    for(; num > 0; num /=10) result += num % 10;

    return result;
}

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine() ?? "0");

Console.WriteLine("Сумма цифр в числе: " + Summator(numberN));