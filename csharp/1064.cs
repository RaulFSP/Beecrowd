using System; 

class URI {

    static void Main(string[] args) { 

        double 
        entrada = 0,
        media = 0;
        int contador = 0;
        for(int i = 0; i < 6; ++i)
        {
            double.TryParse(Console.ReadLine(), out entrada);
            if(entrada > 0)
            {
                media+=entrada;
                ++contador;
            }
        }
        media = media/contador;
        Console.WriteLine($"{contador} valores positivos");
        Console.WriteLine($"{media:F1}");

    }

}