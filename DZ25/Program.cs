Console.WriteLine("Введите 2 числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

double GetExp(int number1, int number2)
{
   double exp = Math.Pow(number1,number2);
   return exp;
}
double result = GetExp(num1,num2);
Console.WriteLine($"{num1}, {num2} -> {result}");