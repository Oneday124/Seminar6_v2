// Напишите программу, которая перевернет одномерный массив (последний будет первым, а первый последним)
// Реализация 1 Без создания нового массива

void RevertArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length -1 - i];
        array[array.Length -1 - i] = temp;
    }
}

int[] CopyRevertArray(int[] array)
{
    int[] copy = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
    {
        copy[i] =  array[^(i+1)]; //array[array.Length - 1 - i]; ^ означает, что элемент берется с конца
    }
    return copy;
}

 void PrintArray(int[] array)
 {
    System.Console.WriteLine(string.Join(", ",array));
 }

int[] array = new int[]{ 1, 2, 3, 4, 5 };

RevertArray(array);
PrintArray(array);
System.Console.WriteLine();

int[] copyOfArray = CopyRevertArray(array);
PrintArray(copyOfArray);
PrintArray(array);