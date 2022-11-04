int value, r, sum = 0, temp;
Console.Write("Eded daxil edin: ");
value = int.Parse(Console.ReadLine());
temp = value;
while (value > 0)
{
    r = value % 10;
    sum = (sum * 10) + r;
    value /= 10;
}
if (temp == sum)
    Console.Write("Eded polindromdur.");
else
    Console.Write("Eded polindrom deil");