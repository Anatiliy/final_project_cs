// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int AkkermanFunction(int m, int n)
{
    if(m == 0 & n > 0)
    {
        return n +1;
    }
    else if(m > 0 & n == 0)
    {
        return AkkermanFunction(m - 1, 1);
    }
    else if(m > 0 & n > 0)
    {
        return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
    }
    else
    {
        return 0;
    }

}


Console.Write("введите m ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("введите n ");
int n = Convert.ToInt32(Console.ReadLine());


if (AkkermanFunction(m, n) > 0)
{
    Console.Write("A(m,n) = ");
    Console.WriteLine(AkkermanFunction(m, n));
}
else
{
    Console.WriteLine("недопустимые значения m и n");
}
