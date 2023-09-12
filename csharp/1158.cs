using System; 

class URI {

    static void Main(string[] args) { 

        int soma = 0, x, y, cont = 1;
        int reps = int.Parse(Console.ReadLine());
        do
        {
            string[] entrada = Console.ReadLine().Split(' ');
            x = int.Parse(entrada[0]);
            y = int.Parse(entrada[1]);
            while(cont <= y)
            {
                if( x % 2 != 0)
                {
                    soma += x;
                    ++cont;            
                }
                ++x;
            }
            Console.WriteLine(soma);
            cont = 1;
            soma = 0;
            --reps;
        } while (reps > 0);

    }

}