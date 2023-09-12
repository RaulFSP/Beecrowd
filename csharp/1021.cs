using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada = Console.ReadLine().Split('.');
        int inteiros = int.Parse(entrada[0]);
        int decimais = int.Parse(entrada[1]);
        int n100, n50, n20, n10, n5, n2, m1, m05, m025, m010, m005, m001;
        n100 = inteiros/100;
        n50 = inteiros%100/50;
        n20 = inteiros%100%50/20;
        n10 = inteiros%100%50%20/10;
        n5 = inteiros%100%50%20%10/5;
        n2 = inteiros%100%50%20%10%5/2;
        m1 = inteiros%100%50%20%10%5%2;
        m05 = decimais/50;
        m025 = decimais%50/25;
        m010 = decimais%50%25/10;
        m005 = decimais%50%25%10/5;
        m001 = decimais%50%25%10%5;
        Console.WriteLine($"NOTAS:");
        Console.WriteLine($"{n100} nota(s) de R$ 100.00");
        Console.WriteLine($"{n50} nota(s) de R$ 50.00");
        Console.WriteLine($"{n20} nota(s) de R$ 20.00");
        Console.WriteLine($"{n10} nota(s) de R$ 10.00");
        Console.WriteLine($"{n5} nota(s) de R$ 5.00");
        Console.WriteLine($"{n2} nota(s) de R$ 2.00");
        Console.WriteLine($"MOEDAS:");
        Console.WriteLine($"{m1} moeda(s) de R$ 1.00");
        Console.WriteLine($"{m05} moeda(s) de R$ 0.50");
        Console.WriteLine($"{m025} moeda(s) de R$ 0.25");
        Console.WriteLine($"{m010} moeda(s) de R$ 0.10");
        Console.WriteLine($"{m005} moeda(s) de R$ 0.05");
        Console.WriteLine($"{m001} moeda(s) de R$ 0.01");

    }

}