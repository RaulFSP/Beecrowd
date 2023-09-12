using System; 

class URI {

    static void Main(string[] args) { 

        string[] valores = Console.ReadLine().Split(' ');
        int largura = int.Parse(valores[0]);
        int altura = int.Parse(valores[1]);
        int cont = 0;
        for (int i = 0; i < altura/largura; ++i)
        {
            for (int j = 0; j < largura; ++j)
            {
                Console.Write($"{++cont}");
                if (j < largura - 1)
                {
                    Console.Write(" ");
                }                    
            }                
            Console.WriteLine();
        }

    }

}