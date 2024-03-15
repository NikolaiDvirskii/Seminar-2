int num = 123;
int[] array = new int[3];

for (int i = 0; i < 3; i++)
{
    array[i] = num % 10;
    Console.Write(array[i] + " ");
    num = num / 10;
}


