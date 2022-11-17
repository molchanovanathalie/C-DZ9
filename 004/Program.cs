// Написать программу возведения числа А в целую стень B
int Stepen(int numberA, int numberB)
{
    if (numberB < 1) return 1;
    return numberA * (Stepen(numberA, numberB - 1));
}

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Число {numberA} в степени {numberB} равно {Stepen(numberA, numberB)}");