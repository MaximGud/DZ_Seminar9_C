// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = 3;
int n = 2;

/// <summary>
/// метод Функции Аккермана
/// </summary>
/// <param name="number1">число 1</param>
/// <param name="number2">число 2</param>
/// <returns></returns>
int AkkermanFunc(int number1, int number2)
{
  if (number1 == 0)
    return number2 + 1;
  else
    if ((number1 != 0) && (number2 == 0))
      return AkkermanFunc(number1 - 1, 1);
    else
      return AkkermanFunc(number1 - 1, AkkermanFunc(number1, number2 - 1));
}

Console.WriteLine(AkkermanFunc(m, n));