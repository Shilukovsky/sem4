Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int GetSum(int number)
{
    int sum = 0;
    while(number >= 1)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
int result = GetSum(num);
Console.WriteLine($"{num} -> {result}");