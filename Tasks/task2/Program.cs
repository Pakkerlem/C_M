// Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
    Console.Write(array[i] + " ");
}
int R = 0;
foreach (int element in array)
{
    if (element % 2 == 0)
    {
        R++;
    }
}
Console.WriteLine("Количество четных элементов= " + R);