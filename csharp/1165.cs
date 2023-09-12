using System; 

class URI {

    static void Main(string[] args) { 

        int reps = int.Parse(Console.ReadLine());
        do
        {
            int entrada = int.Parse(Console.ReadLine());
            int cont = 0;
            for(int i = 1; i <= entrada; i++)
            {
                if(entrada%i == 0)
                {
                    ++cont;
                }
            }
            if (cont == 2)
            {
                Console.WriteLine($"{entrada} eh primo");    
            }
            else
            {
                Console.WriteLine($"{entrada} nao eh primo");    
            }
            --reps;
        } while (reps > 0);

    }

}