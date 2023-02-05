void Fun(int m, int n)
{
    if (m < 0) 
    {
        Console.Write("Пожалуйста, введите M, большее или равное 1.");
        return;
    }
    if (n < 0) 
    {
        Console.Write("Пожалуйста, введите N, большее или равное 1.");
        return;
    }

    int res = Ackermann(m, n);
    Console.Write(res);
}

int Ackermann(int m, int n)
{
    while (m != 0)
    {
        if (n == 0)
        {
            n = 1;
        }
        else
        {
            n = Ackermann(m, n - 1);
        }
        m = m - 1;
    }
    return n + 1;
}

Console.WriteLine("Программа выводит значение функции Аккермана для чисел M и N.");
try
{
    Console.Write("Введите число M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    Fun(m, n);
} catch (FormatException e)
{
    Console.WriteLine("Неправильный формат числа.");
} catch (OverflowException e)
{
    Console.WriteLine("Слишком большое число N.");
}