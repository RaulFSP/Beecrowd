string[] peca1 = Console.ReadLine().Split(' ');
string[] peca2 = Console.ReadLine().Split(' ');
int qtd1 = int.Parse(peca1[1]), qtd2 = int.Parse(peca2[1]);  
float valor1 = float.Parse(peca1[2]), valor2 = float.Parse(peca2[2]);
float totalPagar = (float) (qtd1*valor1+qtd2*valor2);
Console.WriteLine($"VALOR A PAGAR: R$ {totalPagar:F2}");