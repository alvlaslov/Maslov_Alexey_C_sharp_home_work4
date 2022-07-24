// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B

void Solution1()

{
    Console.WriteLine("Insert number A:");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insert a natural number B:");
    int numberB = Convert.ToInt32(Console.ReadLine());
    if (numberB < 0)
    {
        Console.WriteLine("The number B does't natural");
    }
    else
    {
        long result = 1;
        int count = 0;
        while (count < numberB)
        {
            result *= numberA;
            count++;
        }

        Console.WriteLine($"{numberA}^{numberB}={result}");
    }
}


void Solution2()

{
    Console.WriteLine("Insert number A:");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Insert number B:");
    int numberB = Convert.ToInt32(Console.ReadLine());
    if (numberB < 0)
    {
        Console.WriteLine("The number B does't natural");
    }
    else
    {
    long result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result *= numberA;
    }

    Console.WriteLine($"{numberA}^{numberB}={result}");
}
}
Solution1();
Solution2();
