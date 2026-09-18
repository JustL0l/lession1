try
{
    Console.Write("введите температуру в градусах Фаренгейта: ");
    double F = Convert.ToDouble(Console.ReadLine());
    double C = (F - 32) * 5 / 9;
    Console.WriteLine("температура в цельсиях " + C);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}