using System; 

class URI {

    static void Main(string[] args) { 

        double resultado = 0;
        int reps = int.Parse(Console.ReadLine());
        do
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);
            if(y == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else{
                resultado = (double)x / y;
                Console.WriteLine($"{resultado:F1}");
            }
            --reps;
        } while(reps > 0);

    }

}