// Напишите программу, которая задаёт массив из 8 элементов и выводит отсортированный по модулю массив.

int size = 8;
Random random = new Random();
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-10, 10);
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

int temp;
for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (Math.Abs(array[i]) > Math.Abs(array[j]))
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
