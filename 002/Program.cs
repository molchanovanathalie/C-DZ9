// Найти сумму элементов от M до N, N и M заданы
int SumElements(int i, int j)
{
    if (i == j) return i;
    return i + SumElements(i + 1, j);
}
Console.WriteLine(SumElements(1, 8));