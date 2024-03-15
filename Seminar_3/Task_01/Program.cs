int num = 8;
int[] array = new int[] { 1, 2, 3, 6, 10, 9 };
bool flag = false; 
foreach (int item in array)
{
    if(num==item)
    {
        flag = true;
    }
}
if (flag)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}
