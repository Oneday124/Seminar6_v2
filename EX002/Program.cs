// Напишите программу, которая принимает на вход 3 числа и проверяет, может ли существовать треугольник с сторонами такой длинны.

void CheckTheTriangle (int a, int b, int c)
{
    if (a + b > c && b + c > a && c + a > b)
    {
        System.Console.WriteLine("Такой треугольник может существовать");
    }
    else System.Console.WriteLine("Такой треугольник не может существовать");
}

bool IsTriangle(int[] array)
{
    bool flag = true;
    for(int i = 0; flag && i < array.Length; i++)
    {
        flag = array[i] < (array.Sum() - array[i]);
    }
    return flag;
}

System.Console.WriteLine("Введите сторону А: ");
int a = int.Parse(Console.ReadLine() !);
System.Console.WriteLine("Введите сторону B: ");
int b = int.Parse(Console.ReadLine() !);
System.Console.WriteLine("Введите сторону C: ");
int c = int.Parse(Console.ReadLine() !);

CheckTheTriangle(a,b,c);

int[] arrayTriangle = new int[]{a, b, c};
System.Console.WriteLine(IsTriangle(arrayTriangle));