// Дан массив. Найдите МЕХ массива - минимальный отсутствующий элемент

void PrintArray(int[] array)
{
    System.Console.WriteLine(string.Join(" ", array));
}
int Max (int[] array)
{
    int max = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(max<array[i])
        {
            max = array[i];
        }
    }
    return max;
}

int MinExcluded (int[] array, int mex, int max)
{
    int temp = 1;
    while(temp < max)
    {
        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] == mex)
            {
                mex = temp;
            } 
        }
        temp++;
    }
    return mex;
}

System.Console.WriteLine("Введите массив через ',': ");
string[] strings = Console.ReadLine()!.Split(',');
int[] array = new int[strings.Length];
for(int i = 0; i < strings.Length; i++)
{
    array[i] = int.Parse(strings[i]);
}
PrintArray(array);
System.Console.WriteLine($"MEX = {MinExcluded (array, 1, Max(array))}");