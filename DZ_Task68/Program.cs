// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if ((m > 0) && (n == 0)) return AckermannFunction(m - 1, 1);
        else return AckermannFunction(m -1, AckermannFunction(m, n -1));
    }
}

Console.Write("Введите первое неотрицательное число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
if (numberOne < 0) Console.WriteLine("Вы ввели отрицательное число, повторите ввод!");
else
{
    Console.Write("Введите второе неотрицательное число: ");
    int numberTwo = Convert.ToInt32(Console.ReadLine());
    if (numberTwo <= 0) Console.WriteLine("Вы ввели отрицательное число, повторите ввод!");
    else
    {
        int result = default;
        result = AckermannFunction(numberOne, numberTwo);
        Console.Write($"A({numberOne},{numberTwo}) = ");
        Console.Write($"{result}");
    }
}