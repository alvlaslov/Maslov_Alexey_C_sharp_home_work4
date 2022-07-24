// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

    Console.WriteLine("Insert a two-digit number: ");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    if (number < 10)
    {
        Console.WriteLine($"The number {number} does not meet the conditions");
    }
    else
    {
    int sum = 0;
    while (number > 0)

    {
        sum += number % 10;
        number = number / 10;
    }

    Console.WriteLine($"The sum of digits in the number is {sum}");
    }