//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNum(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNum(num - 1 );
}
ShowNum(10);
*/

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int ShowNums(int m, int n)
{
    if(n >= m)
    {
        return n + ShowNums(m, n - 1);
    }
    else if(m >= 0)
    {
        return m + ShowNums(m - 1, n);
    }
    else return 0;
}
Console.WriteLine(ShowNums(1, 5));

*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int ShowNums(int n, int m)
{
  if ((n == 1) && (m == 1))
    return 1;
  else
    if (n > 1)
      return ShowNums(n - 1, m) + m;
    else
      return ShowNums(n, m - 1) + 1;
}
Console.WriteLine(ShowNums(2, 5));
*/
