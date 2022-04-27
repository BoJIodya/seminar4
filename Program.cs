//int method(int A)
//{
//    int i = 1;
//    int summ = 0;
//    while (i <= A)
//    {
//        summ = summ + i;
//        i++;
//    }
//    return summ;
//}

//int A = 25876;
//Console.WriteLine(method(A));

int A = 9;   // второй способ решения, несколько короче, чем если решать через применение метода
int summ = 0;
for (int i = 1; i <= A; i++)
{
    summ = summ + i;
}
Console.WriteLine(summ);