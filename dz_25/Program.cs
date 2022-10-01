// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());

int PowAB(int A, int B){
    int pow = A;
    for (int i = 1; i < B; i++)
    {
        pow *= A;
    }
    return pow;
    }
Console.WriteLine(PowAB(A, B));