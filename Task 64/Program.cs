void Fun(int n)
{
    if (n == 1)
    {
        Console.Write($" {n}");
        return;
    }

    if (n < 1) 
    {
        Console.Write("Пожалуйста, введите N, большее или равное 1.");
        return;
    } else
    {
        Console.Write($" {n}");
    }
    Fun(n - 1);
}

Console.WriteLine("Программа выводит все натуральные числа в промежутке от N до 1.");
Console.Write("Введите натуральное число N: ");

try
{
    int n = Convert.ToInt32(Console.ReadLine());
    Fun(n);
} catch (FormatException e)
{
    Console.WriteLine("Неправильный формат числа, пожалуйста, введите натуральное число N.");
} catch (OverflowException e)
{
    Console.WriteLine("Слишком большое число N.");
}