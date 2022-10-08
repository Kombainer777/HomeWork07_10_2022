// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int sum = 0;
int b = 0;

    while (a>0)
    {
    b = a % 10;
    sum = sum + b;
    a = a / 10;
    }
Console.WriteLine($"Сумма цифр равна:  {sum}");