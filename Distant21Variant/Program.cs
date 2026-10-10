Console.Write("введите стаж работы в годах: ");
double e = double.Parse(Console.ReadLine());
int c = 0;

if (e < 2)
    c = 11;
else if (e >= 2 && e <= 5)
    c= 12;
else if (e > 5)
    c= 13;

Console.WriteLine($"коэффициент учета стажа: {c}");