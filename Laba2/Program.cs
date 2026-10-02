/* лаба 2.2 */

try
{
Console.Write("введите число от 1 до 31: ");
int day = int.Parse(Console.ReadLine());
if (day < 1 || day > 31)
Console.WriteLine("не то число");
else if (day <= 9)
Console.WriteLine("ближайшее событие: новолуние 10 сентября");
else if (day <= 23)
Console.WriteLine("ближайшее событие: полнолуние 24 сентября");
else if (day <= 30)
Console.WriteLine("ближайшее событие: новолуние 8 октября");
else
Console.WriteLine("ближайшее событие: полнолуние 22 октября");
}
catch (Exception e)
{
Console.WriteLine(e.Message);
}




/* на паре */
/*
}
try
{
Console.Write("введите a:");
double a = double.Parse(Console.ReadLine());
Console.Write("введите b:");
double b = double.Parse(Console.ReadLine());
Console.Write("введите c:");
double c = double.Parse(Console.ReadLine());
if ((a < b) && (b < c)) Console.WriteLine($"{a}<{b}<{c}");
else Console.WriteLine(("не выполняется");
}
catch (Exception e)
{
Console.WriteLine(e.Message);
}

try
{
Console.Write("введите m:");
int m = int.Parse(Console.ReadLine());
int a = m / 100;
int b = m / 10 % 10;
int c = m % 10;
if ((a == 4 || b == 4 || c == 4) || (a == 7 || b == 7 || c == 7))
Console.WriteLine("да");
else Console.WriteLine("нет");
if ((a == 3 || b == 9 || c == 9)) Console.WriteLine("да");
else Console.WriteLine("нет");
}
catch (Exception e)
{
Console.WriteLine(e.Message);
}
*/
