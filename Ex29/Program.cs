// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Ограничения:
// - Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
// - Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода или в функции вывода
void printArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < 8; i++)
        if (i < 8 - 1)
            Console.Write(array[i] + ", ");
        else
            Console.Write(array[i]);
    Console.WriteLine(" ]");
}
int[] fillArray()
{
    Random rnd = new Random();
    int[] array = new int[rnd.Next(10, 100)];
    int len = 8;
    for (int i = 0; i < len; i++)
    {
        array[i] = rnd.Next(1, 10);
    }
    return array;
}
printArray(fillArray());