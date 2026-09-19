
try
{
    Console.Write("Введите полученное число: ");
    int y = int.Parse(Console.ReadLine());
    int d = y / 100;
    int q = y % 100;
    int x = q * 10 + d;
    Console.WriteLine($"Исходное число x = {x}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}