// Напишите программу, которая будет преобразовывать десятичное число в двоичное. Через массив

int[] GetBinaryArray(int num)
{
    int[] array = new int[(int)Math.Log2(num) + 1 ];
    for (int i = 0; i < array.Length; i++)
    {
        array[^(i+1)] = num % 2;
        num = num / 2;
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(string.Join("",array));
}

System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() !);

PrintArray(GetBinaryArray(num));
