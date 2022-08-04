int[] array = new int [8];
int rndNum = new Random().Next(0, 2);

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
}
for (int i = 0; i < array.Length; i++)
{
    
    Console.Write(array[i] + ", ");
}