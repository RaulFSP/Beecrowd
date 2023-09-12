double n1, n2, media;
double.TryParse(Console.ReadLine(), out n1);
double.TryParse(Console.ReadLine(), out n2);
media = (n1*3.5 + n2*7.5)/11.0;
Console.WriteLine($"MEDIA = {media:F5}");