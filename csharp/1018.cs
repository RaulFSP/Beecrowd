using System; 

class URI {

    static void Main(string[] args) { 

        int entrada;
        int.TryParse(Console.ReadLine(), out entrada);
        int n100, n50, n20, n10, n5, n2, n1, temp;
        n100 = entrada/100;
        n50 = entrada%100/50;
        temp = entrada%100%50;
        n20 = temp/20;
        n10 = temp%20/10;
        temp = temp%20%10;
        n5 = temp/5;
        n2 = temp%5/2;
        n1 = temp%5%2;
        Console.WriteLine($"{entrada}");
        Console.WriteLine($"{n100} nota(s) de R$ 100,00");
        Console.WriteLine($"{n50} nota(s) de R$ 50,00");
        Console.WriteLine($"{n20} nota(s) de R$ 20,00");
        Console.WriteLine($"{n10} nota(s) de R$ 10,00");
        Console.WriteLine($"{n5} nota(s) de R$ 5,00");
        Console.WriteLine($"{n2} nota(s) de R$ 2,00");
        Console.WriteLine($"{n1} nota(s) de R$ 1,00");
    }

}