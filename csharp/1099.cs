using System; 

class URI {

    static void Main(string[] args) { 

        int reps = int.Parse(Console.ReadLine());
        int min = 0, max = 0, soma = 0;
        do
        {
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);
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
            for (int i = max-1; i > min; --i)
            {
                if(i%2!=0)
                {
                    soma+=i;
                }                    
            }
            Console.WriteLine(soma);
            soma = 0;
            --reps;
        } while (reps > 0);

    }

}