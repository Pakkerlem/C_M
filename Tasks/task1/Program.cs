// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 101);
    Console.Write(array[i] + " ");
}
int R = 0;
foreach (int element in array)
{
    if (element >= 20 && element <= 90)
    {
        R++;
    }
}
Console.WriteLine("Количество элементов= " + R);