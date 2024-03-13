// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void FillArray(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 10);
    }
}

void Reverse(int[] array, int i)
{
    if (i > 0)
        Console.Write($"{array[i]}, ");
    else
        Console.Write(array[i]);

    if (i == 0)
        return;
    else
        Reverse(array, i - 1);
}

Random random = new Random();
int[] array = new int[random.Next(7, 10)];
FillArray(array);
Console.WriteLine(string.Join(", ", array));

int count = array.Length - 1;
Reverse(array, count);