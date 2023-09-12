double area, raio;
double.TryParse(Console.ReadLine(), out raio);
area = 3.14159*Math.Pow(raio,2);
Console.WriteLine($"A={area:F4}");
