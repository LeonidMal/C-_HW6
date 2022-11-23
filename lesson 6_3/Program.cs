int ReadInt (string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int num = ReadInt("Введите число: ");
int count = 0;
int[] binar = new int[ArraySize(num)];


int ArraySize (int number)
{
    
    for (int i = num; i > 1; i /= 2)
    {
        count++;
    }
    return count -= 1;
}

Console.WriteLine($"{ArraySize(num)}");