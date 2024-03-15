int[] array1 = new int[] { 1, 2, 3, 6, 9 };
int[] array2 = new int[array1.Length / 2];

for (int i = 0; i < array1.Length / 2; i++)
{
    array2[i] = array1[i] * array1[array1.Length - 1 - i];
    Console.Write(array2[i] + " ");
}
