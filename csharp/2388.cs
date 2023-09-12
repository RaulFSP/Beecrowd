using System; 

class URI {

    static void Main(string[] args) { 

        int reps = int.Parse(Console.ReadLine());
        int soma = 0;
        do
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int tempo = int.Parse(entrada[0]);
            int velocidade = int.Parse(entrada[1]);
            soma+= (tempo*velocidade);
            --reps;
        } while (reps > 0);
        Console.WriteLine(soma);

    }

}