using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada = Console.ReadLine().Split(' ');
        int h1 = int.Parse(entrada[0]), h2 = int.Parse(entrada[1]), resultado = 0;
        if (h1 > h2)
        {
            resultado = (24-h1)+h2;
            Console.WriteLine($"O JOGO DUROU {resultado} HORA(S)");
        }
        else if (h1 < h2)
        {
            resultado = h2 - h1;
            Console.WriteLine($"O JOGO DUROU {resultado} HORA(S)");
        }
        else
        {
            resultado = (24-h1)+h2;
            Console.WriteLine($"O JOGO DUROU 24 HORA(S)");
        }

    }

}