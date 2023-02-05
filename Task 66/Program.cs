void Fun(int m, int n)
{
    if (m > n) 
    {
        Console.Write("Пожалуйста, введите M, меньшее или равное N.");
        return;
    }
    if (m < 1) 
    {
        Console.Write("Пожалуйста, введите M, большее или равное 1.");
        return;
    }
    if (n < 1) 
    {
        Console.Write("Пожалуйста, введите N, большее или равное 1.");
        return;
    }

    int res = CalcSumMToN(m, n , 0);
    Console.Write(res);
}

int CalcSumMToN(int m, int n, int sum)
{
    if (m > n)
    {
        return sum;
    } 
    else
    {
        return CalcSumMToN(m, n - 1, sum + n);
    }
}

Console.WriteLine("Программа выводит сумму всех натуральных чисел в промежутке от M до N.");
try
{
    Console.Write("Введите натуральное число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите натуральное число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Fun(m, n);
} catch (FormatException e)
{
    Console.WriteLine("Неправильный формат числа, пожалуйста, введите натуральное число N.");
} catch (OverflowException e)
{
    Console.WriteLine("Слишком большое число N.");
}