using System; 

class URI {

    static void Main(string[] args) { 

        double entrada;
        int 
        i = 6,
        contador = 0;
        while (i > 0)
        {
            double.TryParse(Console.ReadLine(), out entrada);
            if(entrada > 0)
            {
                ++contador;
            }
            --i;
        }
        Console.WriteLine($"{contador} valores positivos");

    }

}