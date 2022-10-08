// Найти кубы чисел от 1 до N
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int a = 1;
while (a<=N)
{
    int b = a*a*a;                          //Math.Pow(a,3);
    Console.WriteLine($"Куб числа {a} равен {b}");
    a++;
}
