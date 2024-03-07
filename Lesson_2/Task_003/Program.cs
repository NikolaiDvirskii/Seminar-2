// int n = 10;
int[] array = { 2, 3, 5, 10, 22, 15, 30, 8, 7, 4 };
int i = 0;
while(i < array.Length)
{
    if(array[i] % 2 == 0)
    {
        Console.Write(array[i]);
        Console.Write(" ");
    }
i++;
}