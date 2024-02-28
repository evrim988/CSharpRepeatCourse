// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

if (isPrimeNumber(6))
{
    Console.WriteLine("girilen sayı asal sayıdır.");
}

Console.WriteLine("Girilen sayı asal değildir.");

static bool isPrimeNumber(int number)
{
    bool result = true;
    for (int i = 0; i <= number - 1; i++)
    {
        if (number % i == 0)
            result = false;
    }
    return result;
}