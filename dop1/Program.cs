// Дополнительная задача (задача со звёздочкой): Напишите программу, которая задаёт массив из 10 элементов, которые
// необходимо заполнить случайными значениями в диапазоне от -10 до 10 и найти максимальное значение среди них.
// [-1, 2, 4, 6, -7, 9, -3, -4, -6 ,1] -> 9
// [-5, 1, -9, 6, -7, -2, -3, -4, -6 ,1] -> 6
// [-7, 2, 4, 6, -7, 7, -3, -4, -2 ,1] -> 7

Console.Clear();
int size = 10;
int[] numbers = new int[size];
FillArray(numbers);

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-10, 11);
    }
}

int FindMax(int[] numbers)
{
    int max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        max = numbers[i];
    }
    return max;
}

Console.WriteLine("[" + String.Join(",", numbers) + "]");
Console.WriteLine(FindMax(numbers));