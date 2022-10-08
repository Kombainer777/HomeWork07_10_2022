// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
int a = 1;
int fct = 1;
while (a <= N)
{
    fct = fct * a;
    a++;
}
Console.WriteLine($"Произведение всех чисел от 1 до указанного числа {N} равняется {fct}");