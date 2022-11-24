// Пользователь вводит с клавиатуры М чисел. Посчитайте сколько чисел больше 0 ввел пользователь

void PrintArray(int[] array)
{
    System.Console.WriteLine(string.Join(" ", array));
}

System.Console.WriteLine("Введите числа через ',' ");
string[] strings = Console.ReadLine()!.Split(',');
int[] array = new int[strings.Length];
for(int i = 0; i < strings.Length; i++)
{
    array[i] = int.Parse(strings[i]);
}
 
PrintArray(array);

int result = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    {
        result++;
    }
}
System.Console.WriteLine(result);