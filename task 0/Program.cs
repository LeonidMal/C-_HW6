/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4*/


string m = ReadInt("Введите числа через запятую: ") + ',';
int[] numArray = GetArray(m, ',');
int evenNum = 0;

string ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine();
}


int[] GetArray (string input, char name)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == name)
            count++;
    }
    int[] array = new int[count];
    int index = 0;
    string temp = string.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != name)
            temp += input[i];
        else
        {
            array[index] = Convert.ToInt32(temp);
            temp = string.Empty;
            index++;
        }    
    }
    return array;
}

for (int i = 0; i < numArray.Length; i++)
{
    if (numArray[i] > 0)
        evenNum++;
}

void Print(string result)
{
    Console.WriteLine($"{result} -> {evenNum}");
}

Print(m);