using System; 

class URI {

    static void Main(string[] args) { 

        int 
        entrada = 0,
        contador = 0;
        for(int i = 0; i < 5; ++i)
        {
            int.TryParse(Console.ReadLine(), out entrada);
            if(entrada%2 == 0)
            {
                ++contador;
            }
        }
        Console.WriteLine($"{contador} valores pares");

    }

}