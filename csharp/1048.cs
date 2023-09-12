using System; 

class URI {

    static void Main(string[] args) { 

        float entrada;
        float.TryParse(Console.ReadLine(), out entrada);
        float reajuste = 0f, percentual = 0f, novoSalario = 0f;
        
        if (entrada > 2000)
        {
            percentual = 0.04f;
            reajuste = (float) (entrada*percentual);
            novoSalario = reajuste + entrada;
        }
        else if (entrada > 1200 && entrada <= 2000)
        {
            percentual = 0.07f;
            reajuste = (float) (entrada*percentual);
            novoSalario = reajuste + entrada;
        }
        else if (entrada > 800 && entrada <= 1200)
        {
            percentual = 0.10f;
            reajuste = (float) (entrada*percentual);
            novoSalario = reajuste + entrada;
        }
        else if (entrada > 400 && entrada <= 800)
        {
            percentual = 0.12f;
            reajuste = (float) (entrada*percentual);
            novoSalario = reajuste + entrada;
        }
        else
        {
            percentual = 0.15f;
            reajuste = (float) (entrada*percentual);
            novoSalario = reajuste + entrada;
        }
        Console.WriteLine($"Novo salario: {novoSalario:F2}");
        Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
        Console.WriteLine($"Em percentual: {percentual*100} %");

    }

}