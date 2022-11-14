int a = new Random().Next(1, 20);
Console.WriteLine(a);
int b = new Random().Next(1, 20);
Console.WriteLine(b);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
Console.Write("max = ");
Console.WriteLine(max);

int min = b;
if (a < min) min = a;
if (b < min) min = b;
Console.Write("min = ");
Console.Write(min);