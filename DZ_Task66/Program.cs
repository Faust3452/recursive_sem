// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int SumNaturalNumbers(int firstNum, int secondNum)
{
    if (firstNum < secondNum)
    {
        return firstNum + SumNaturalNumbers(firstNum + 1, secondNum);
    }
    else
    {
        if (firstNum == secondNum) return firstNum;
        return secondNum + SumNaturalNumbers(firstNum, secondNum + 1);
    }
}

Console.Write("Введите первое натуральное число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
if (numberOne <= 0) Console.WriteLine("Вы ввели не натуральное число, повторите ввод!");
else
{
    Console.Write("Введите второе натуральное число: ");
    int numberTwo = Convert.ToInt32(Console.ReadLine());
    if (numberTwo <= 0) Console.WriteLine("Вы ввели не натуральное число, повторите ввод!");
    else
    {
        int sum = default;
        sum = SumNaturalNumbers(numberOne, numberTwo);
        Console.WriteLine($"{sum}");
    }
}