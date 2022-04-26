int method(int A)
{
    int i = 1;
    int summ = 0;
    while (i <= A)
    {
        summ = summ + i;
        i++;
    }
    return summ;
}

int A = 25876;
Console.WriteLine(method(A));