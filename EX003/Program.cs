// Напишите программу, которая будет преобразовывать десятичное число в двоичное. Через массивы

int LengthArray (int num)
{
    int i = 0;
    while (num > 0)
    {
        int ost = num % 2;
        num = num / 2;
        i++;
    }
    return i;
}
void FillArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = num % 2;
        num = num / 2;
    }
}
void RevertArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length -1 - i];
        array[array.Length -1 - i] = temp;
    }
}
void PrintArray(int[] array)
{
    Console.WriteLine(string.Join("",array));
}

System.Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() !);

int[] array = new int[LengthArray(num)];
FillArray(array, num);
RevertArray(array);
PrintArray(array);
