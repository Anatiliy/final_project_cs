// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.

//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30


int NaturalNumbers(int m, int n, int result = 0)
{
    if (m == n)
    {
      return m;
    }
    else
    {
      return result = m + NaturalNumbers( m + 1, n);
    }
}


Console.Write("введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int naturalnumber = NaturalNumbers(m, n);
Console.WriteLine(naturalnumber);