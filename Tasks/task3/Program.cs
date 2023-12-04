// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

Random random = new Random();
int arrayLength = random.Next(10, 30);

int[] array = new int[arrayLength];

for (int i = 0; i < arrayLength; i++)
{
    array[i] = new Random().Next(1, 101);
}

int min = array[0];
int max = array[0];

foreach (int num in array)
{
    if (num < min)
    {
        min = num;
    }
    if (num > max)
    {
        max = num;
    }
}

int dif = max - min;

Console.WriteLine("Максимальный элемент: " + max);
Console.WriteLine("Минимальный элемент: " + min);
Console.WriteLine("Разница между максимальным и минимальным элементом: " + dif);