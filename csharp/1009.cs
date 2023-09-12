string nome = Console.ReadLine();
float salarioFixo, vendasEfetuadas, total;
float.TryParse(Console.ReadLine(), out salarioFixo);
float.TryParse(Console.ReadLine(), out vendasEfetuadas);
total = (float)(salarioFixo + (vendasEfetuadas * 0.15));
Console.WriteLine($"TOTAL = R$ {total:F2}");