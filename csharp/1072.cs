using System; 

class URI {

    static void Main(string[] args) { 

        int
        entrada,
        x,
        dentro = 0,
        fora = 0;
        int.TryParse(Console.ReadLine(), out entrada);
        do
        {
            int.TryParse(Console.ReadLine(), out x);
            if (x >= 10 && x <= 20)
            {
                ++dentro;
            }
            else
            {
                ++fora;
            }
            --entrada;
        } while (entrada > 0);
        Console.WriteLine($"{dentro} in");
        Console.WriteLine($"{fora} out");

    }

}