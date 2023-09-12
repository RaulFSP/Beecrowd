using System; 

class URI {

    static void Main(string[] args) { 

        int entrada, resultado = 0;
        int.TryParse(Console.ReadLine(), out entrada);
        for(int i = 1; i <= entrada; ++i)
        {
            if (i % 2 == 0)
            {
                resultado = (int) Math.Pow(i,2);
                Console.WriteLine($"{i}^2 = {resultado}");
            }
        }

    }

}