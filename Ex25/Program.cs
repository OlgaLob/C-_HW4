// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Ограничения:
// - Нельзя использовать класс Math
// - Должна быть отдельная функция Power, которая возвразает результат
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

int power(int baseNum, int deg)
{
    int result = 1;

    for (int i = 0; i < deg; i++)
        result *= baseNum;

    return result;
}


int number = 0;
int degree = 0;

Console.Write("Введите целое число А: ");
number = Convert.ToInt32(Console.ReadLine());

while (true)
{
    Console.Write("Введите натуральное число В: ");
    degree = Convert.ToInt32(Console.ReadLine());
    if (degree > 0)
        break;
    else
        Console.WriteLine("Число В введено некорректно");
}


Console.WriteLine(power(number, degree));
