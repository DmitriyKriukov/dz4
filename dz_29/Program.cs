// Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());
int[] numbers = new int[N];
FillArray(numbers);

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 100);
    }
}

Console.WriteLine("[" + String.Join(",", numbers) + "]");