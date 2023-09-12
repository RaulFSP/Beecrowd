double n1, n2, n3, media;
double.TryParse(Console.ReadLine(), out n1);
double.TryParse(Console.ReadLine(), out n2);
double.TryParse(Console.ReadLine(), out n3);
media = (n1*2 + n2*3+ n3*5)/10.0;
Console.WriteLine($"MEDIA = {media:F1}");