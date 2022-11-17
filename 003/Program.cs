// Написать программу вычисления функции Аккермана
int Akkerman(int i, int j)
{
    if (i >6 || j > 6 || i< 0 ||j < 0) 
    return -1;

    if (i== 0)
    {
        return j + 1;
    }
    else if (j== 0)
    {
        return Akkerman(i- 1, 1);
    }
    else
    {
        return Akkerman(i - 1,Akkerman(i, j - 1));
    }
}
Console.WriteLine(Akkerman(2, 3));