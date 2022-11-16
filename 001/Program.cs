// Показать натуральные числа от M до N, N и M заданы
void RecurNM(int i, int j)
{
    if (j < i) return;
    RecurNM(i, j - 1);
    Console.Write(j + " ");
}
RecurNM(3, 11);
