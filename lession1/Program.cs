/*Console.Write("Введите самый лучший шрифт");
string name = Console.ReadLine();
Console.WriteLine("Этим шрифтом является" + name);
Console.WriteLine("Этим шрифтом является{0}", name);
Console.WriteLine($"Этим шрифтом является{name}");

Console.Write("Введите x:");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y:");
int y = Convert.ToInt32(Console.ReadLine());
int s = x + y;
Console.WriteLine($"{x}+{y}={s}");

float x = 3.7F
double y = Math.Pow(x,7);
Console.Write("Введите угол в градусах");
double angle = double.Parse(Console.ReadLine());
Double y = Math.Sin(angle * Math.PI / 180);
Console.WriteLine($"y={y}");

double number = double.Parse(Console.ReadLine());
double y = Math.Exp(7 * number);
Console.WriteLine($"y={y:f2}");*/

/*Console.WriteLine($"{Math.PI:F2}");
Console.WriteLine($"{Math.E:F1}");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"Вы ввели число {a} ");

int a = int.Parse(Console.ReadLine());
Console.WriteLine($"{a} - Вот какое число Вы ввели: ");
Console.WriteLine("1 13 49");
Console.WriteLine("7  15  100");*/

/*try
{
    Console.Write("Введите a: ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Введите b: ");
    double b = double.Parse(Console.ReadLine());
    Console.Write("Введите c: ");
    double c = double.Parse(Console.ReadLine());
    double d = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 + a);
    Console.WriteLine($"{d:F2}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}*/

/*try
{
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите y:");
    double y = double.Parse(Console.ReadLine());
    double z = (x + ((2 + y) / (x * x)) / (y + (1 / Math.Sqrt(x * x + 10))));
    Console.WriteLine($"q={z:F2}");
    double q = 2.8 * Math.Sin(x) + Math.Abs(y);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}*/

/*try
{
    Console.Write("Введите количество сантиметров: ");
    int sm=int.Parse(Console.ReadLine());
    int m = sm / 100;
    Console.WriteLine($"Полных метров {m}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}*/

try
{
    Console.Write("Введите четырёхзначное число: ");
    int n = int.Parse(Console.ReadLine());
    int a = n % 10;
    int b = n % 100 / 10;
    int c = n % 1000 / 100;
    int d = n / 1000;
    int s = a + b + c + d;
    Console.WriteLine(s);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}









//-----2.2----//
try
{
    Console.Write("Введите массу в килограммах: ");
    int kg = int.Parse(Console.ReadLine());
    int c = kg / 100;
    Console.WriteLine($"Полных центнеров {c}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//-----2.3----//
try
{
    Console.Write("Введите массу в килограммах: ");
    int kg = int.Parse(Console.ReadLine());
    int t = kg / 1000;
    Console.WriteLine($"Полных тонн {t}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

//-----2.4----//
try
{
    Console.Write("Введите расстояние в метрах: ");
    int m = int.Parse(Console.ReadLine());
    int km = m / 1000;
    Console.WriteLine($"Полных километров {km}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}







