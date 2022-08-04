Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());

//int sum = 0;
//for (int i = 1; i <= A; i++)
//{
//    sum = sum + i;
//}

//Console.WriteLine($"Сумма чисел от 1 до {A} = {sum}");

int GetSum (int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
    sum = sum + i;
    }
    return sum;    
}
int result = GetSum(A);
Console.WriteLine($"Сумма чисел от 1 до {A} = {result}");