/*//база
Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.Write("Введите r:");
double r = double.Parse(Console.ReadLine());
double W = Math.Exp(y + r) + 7.2 * Math.Sin(r);
Console.WriteLine($"W={W:F2}");*/

/*//среднячок
Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.Write("Введите p:");
double p = double.Parse(Console.ReadLine());
double N = (3 * y * y + Math.Sqrt(y + 1)) / (Math.Log(p + y) + Math.Exp(p));
Console.WriteLine($"W={N:F2}");
*/

/*//высокий
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
double K = (Math.Sqrt(Math.Pow(3 + x, 6) - Math.Log(x))) / (Math.Exp(0) + Math.Asin(6 * x * x));
Console.WriteLine($"K={K:F2}");

*/


//вариант 26
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите y:");
double y = double.Parse(Console.ReadLine());
Console.Write("введите k:");
double k = double.Parse(Console.ReadLine());
double U = (Math.Log(Math.Pow(x, 3) + y) - Math.Pow(y, 4)) / (Math.Exp(y) + 5.4 * Math.Pow(k, 3));
Console.WriteLine($"U={U:F2}");