// Напишите программу, которая будет преобразовывать десятичное число в двоичное. Через строку

string Translation (int num)
{
    string result = "";
    while (num > 0)
    {
        int ost = num % 2;
        num = num / 2;
        result = ost + result; 
    }
    return result;
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() !);

System.Console.WriteLine(Translation(num));