// Написать программу возведения числа А в целую стень B
int Stepen(int A, int B)
{
    if (B < 1) return 1;
    return A * (Stepen(A, B - 1));
}

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Число {A} в степени {B} равно {Stepen(A,B)}");