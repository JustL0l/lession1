// средний уровень, 21 вариант

try
{
    Console.Write("введите номер варианта: ");
int n = int.Parse(Console.ReadLine());
Console.Write("введите x: ");
double x = double.Parse(Console.ReadLine());
double a = 0;
double b = 0;
double z = 0;
switch (n)
{
    case 1:
        {
            a = 4.5; b = 8.4; z = Math.Pow(Math.Tan(b * x), 2);
        }
        break;
    case 2:
        {
            a = 8.2; b = 15.2; z = Math.Pow(Math.Tan(b * x), 2);
        }
        break;
    case 3:
        {
            a = 1.7; b = 0.5; z = Math.Pow(Math.Tan(b * x), 2);
        }
        break;
    default:
            Console.WriteLine("нет такого варианта");
            return;
    }
    double y = 0;
    if (x <= a)
    {
        y = a * Math.Pow(Math.Cos(x), 2) + b * Math.Sin(z * x);
    }
    else if (x > a && x <= 4.5 * b)
    {
        y = a * Math.Tan(a * x + z) + Math.Pow(Math.Sin(b * x), 2);
    }
    else
    {
        y = Math.Log(a * x - b) + Math.Pow(z, 2);
    }
    Console.WriteLine($"y = {y:F2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}





// на паре

/*try
{
    int n = int.Parse(Console.ReadLine());
    switch (n)
    {
        case 1:
            Console.WriteLine("понедельник");
            break;
        case 2:
            Console.WriteLine("вторник");
            break;
        case 3:
            Console.WriteLine("среда");
            break;
        case 4:
            Console.WriteLine("четверг");
            break;
        case 5:
            Console.WriteLine("пятница");
            break;
        case 6:
            Console.WriteLine("суббота");
            break;
        case 7:
            Console.WriteLine("воскресенье");
            break;
        default:
            Console.WriteLine("нет такого дня недели");
            break;
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


try
{
    Console.Write("введите номер месяца: ");
    int n = int.Parse(Console.ReadLine());
    switch (n)
    {
        case 12:
        case 1:
        case 2:
            Console.WriteLine("зима");
            break;
        case 3:
        case 4:
        case 5:
            Console.WriteLine("весна");
            break;
        case 6:
        case 7:
        case 8:
            break;
            Console.WriteLine("лето");
        case 9:
        case 10:
        case 11:
            Console.WriteLine("осень");
            break;
        default:
            Console.WriteLine("нет такого месяца");
            break;

    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}*//*


Console.Write("Введите номер карты: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите номер масти: ");
int m = int.Parse(Console.ReadLine());

switch (n)
{
    case 6: Console.Write("Шестерка "); 
        break;
    case 7: Console.Write("Семерка "); 
        break;
    case 8: Console.Write("Восьмерка "); 
        break;
    case 9: Console.Write("Девятка "); 
        break;
    case 10: Console.Write("Десятка "); 
        break;
    case 11: Console.Write("Валет "); 
        break;
    case 12: Console.Write("Дама "); 
        break;
    case 13: Console.Write("Король "); 
        break;
    case 14: Console.Write("Туз "); 
        break;
    default: Console.Write("Нет такой карты "); 
        break;
}

switch (m)
{
    case 1:
        Console.WriteLine("пик");
        break;
    case 2:
        Console.WriteLine("треф");
        break;
    case 3:
        Console.WriteLine("бубен");
        break;
    case 4:
        Console.WriteLine("червей");
        break;
    default:
        Console.WriteLine("нет такой масти");
        break;
}*//*


Console.Write("введите число: ");
int n = int.Parse(Console.ReadLine());

Console.Write(n);
if (n % 100 >= 11 && n % 100 <= 14)
{
    Console.WriteLine("рублей");
}
else
{
    switch (n % 10)
    {
        case 1:
            Console.WriteLine("рубль");
            break;
        case 2:
        case 3:
        case 4:
            Console.WriteLine("рубля");
            break;
        default:
            Console.WriteLine("рублей");
            break;
    }
}*//*



try
{
    Console.Write("Введите число: ");
    double x = double.Parse(Console.ReadLine());
    if ((int)x % 100 >= 11 && (int)x % 100 <= 14) Console.WriteLine($"{x} рублей");
    else
    {
        switch ((int)x % 10)
        {
            case 1:
                Console.WriteLine($"{x} рубль");
                break;
            case 2:
            case 3:
            case 4:
                Console.WriteLine($"{x} рубля");
                break;
            default:
                Console.WriteLine($"{x} рублей");
                break;
        }
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}*/
