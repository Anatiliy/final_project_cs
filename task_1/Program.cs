// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.


void NaturalNumbers(int n, int i = 0)
{ 
  if (i < n)
  {
    Console.Write(n - i);
    Console.Write(" ");
    NaturalNumbers(n, i + 1);
  }
  else
  {
    Console.WriteLine();
  }
}

Console.Write("введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(n);
