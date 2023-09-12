using System; 

class URI {

    static void Main(string[] args) { 

        int min = 1, max = 1, soma = 0, x, y;
        while (min > 0 && max > 0)
        {
            string[] valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);
            if (x > y)
            {
                min = y;
                max = x;
            }
            else
            {
                min = x;
                max = y;
            }
            if (min > 0 && max > 0)
            {
                for(int i = min; i <= max; ++i)
                {
                    Console.Write($"{i} ");
                    soma+=i;                    
                }
                Console.WriteLine($"Sum={soma}");
                soma = 0;
            }
            else
            {
                break;
            }                
        }

    }

}