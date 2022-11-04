int n, r, sum = 0, temp;
Console.Write("Eded daxil edin: ");
n = int.Parse(Console.ReadLine());
temp = n;
while (n > 0)
{
    r = n % 10;
    sum = (sum * 10) + r;
    n /= 10;
}
if (temp == sum)
    Console.Write("Eded polindromdur.");
else
    Console.Write("Eded polindrom deil");