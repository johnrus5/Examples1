﻿int a = new Random().Next(1, 20);
Console.WriteLine(a);
int b = new Random().Next(1, 20);
Console.WriteLine(b);
int c = new Random().Next(1, 20);
Console.WriteLine(c);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("max = ");
Console.WriteLine(max);
