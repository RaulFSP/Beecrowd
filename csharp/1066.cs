using System; 

class URI {

    static void Main(string[] args) { 

        int 
        entrada = 0,
        contadorPar = 0,
        contadorImpar = 0,
        contadorPositivo = 0,
        contadorNegativo = 0;
        for(int i = 0; i < 5; ++i)
        {
            int.TryParse(Console.ReadLine(), out entrada);
            if(entrada%2 == 0)
            {
                ++contadorPar;
            }
            else
            {
                ++contadorImpar;
            }
            if(entrada > 0)
            {
                ++contadorPositivo;
            }
            else if (entrada < 0)
            {
                ++contadorNegativo;
            }
        }
        Console.WriteLine($"{contadorPar} valor(es) par(es)");
        Console.WriteLine($"{contadorImpar} valor(es) impar(es)");
        Console.WriteLine($"{contadorPositivo} valor(es) positivo(s)");
        Console.WriteLine($"{contadorNegativo} valor(es) negativo(s)");

    }

}