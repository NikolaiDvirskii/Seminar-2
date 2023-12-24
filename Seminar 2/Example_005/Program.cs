Console.WriteLine("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
    Console.WriteLine("Третьей цифры нет");
else
{
    while (n > 999)
        n /= 10;
    Console.WriteLine(n % 10);
}