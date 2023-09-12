using System; 

class URI {

    static void Main(string[] args) { 

        double entrada;
        double.TryParse(Console.ReadLine(), out entrada);
        double imposto, taxa, valor;
        if (entrada > 2000 && entrada <= 3000)
        {
            taxa = 0.08;
            valor = entrada - 2000.00;    
            imposto = valor * taxa;
            Console.WriteLine($"R$ {imposto:F2}");
        }
        else if (entrada > 3000 && entrada <= 4500)
        {
            taxa = 0.18;
            valor = entrada - 3000.00;    
            imposto = (valor * taxa)+(1000*0.08);
            Console.WriteLine($"R$ {imposto:F2}");
        }
        else if (entrada > 4500)
        {
            taxa = 0.28;
            valor = entrada - 4500.00;    
            imposto = (valor * taxa)+(1500*0.18)+(1000*0.08);
            Console.WriteLine($"R$ {imposto:F2}");
        }
        else
        {
            Console.WriteLine("Isento");
        }
    
    }

}