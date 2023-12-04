// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

Console.Clear();
Random random = new Random();
int arrayLength = random.Next(1, 100001);
int[] array = new int[arrayLength];
int i = 0;

while (i < arrayLength)
{
    array[i] = arrayLength - i;
    i++;
}

for (i = 0; i < arrayLength; i++)
{
    System.Console.Write(" " + array[i]);
}

Console.WriteLine(" Количество элементов:  " + arrayLength);