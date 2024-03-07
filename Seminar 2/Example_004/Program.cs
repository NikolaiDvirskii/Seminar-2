Console.Write("Enter a first number:");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a second number:");
int n2 = Convert.ToInt32(Console.ReadLine());
if (n1 % n2 == 0)
    Console.WriteLine("Кратно");
else
    Console.WriteLine("Не кратно " + n1 % n2);