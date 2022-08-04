Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int GetCountNum(int number)
{
    int ind =1;
    int x = 0;
    while (ind <=number)
    {
       x++;
       ind = ind * 10;
    }
    return x;
}
int result = GetNum(num);
Console.WriteLine($"Количество цифр в числе {result}");