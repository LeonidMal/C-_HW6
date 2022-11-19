int size = 5;
int[] array = new int [size];
int[] multiples;

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(1, 10);
}

if (array.Length % 2 == 0)
{
    multiples = new int[array.Length / 2];
}
else
{
    multiples = new int[array.Length / 2 + 1];
    multiples[multiples.Length - 1] = array[array.Length / 2];
}

for (int i = 0; i < array.Length / 2; i++)
{
    multiples[i] = array[i] * array[array.Length - 1 - i];
}

PrintArray(array);
PrintArray(multiples);

void PrintArray (int[] arr)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}