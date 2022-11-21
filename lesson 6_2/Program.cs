int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int a = ReadInt("Введите размер стороны a");
int b = ReadInt("Введите размер стороны b");
int c = ReadInt("Введите размер стороны c");

bool CheckSize (int checking, int first, int second)
{
    return checking < first + second;
}

if (CheckSize (a, b, c) && CheckSize (b, a,c) && CheckSize (c, a, b)) Console.WriteLine("Треугольнику есть место быть");
else Console.WriteLine("Такого треугольника не существует");
