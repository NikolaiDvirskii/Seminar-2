Console.Clear();
Console.Write("Введите трёхзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 100 || n > 999)
{
    Console.Write("Error! Enter the other number: ");
    n = Convert.ToInt32(Console.ReadLine());
}
int n2 = n / 10 % 10;
int n3 = n % 10;
int result = 1;
// for (int i = 1; i <= n3; i++)
// {
//     result *= n2;
// }
// Console.WriteLine("Loop:" + result);
Console.WriteLine(Math.Pow(n2, n3));
