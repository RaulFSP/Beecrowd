using System; 

class URI {

    static void Main(string[] args) { 

        int 
        soma = 0,
        chaCerto = int.Parse(Console.ReadLine());
        string[] entrada = Console.ReadLine().Split(' ');
        int[] valoresInteiros = Array.ConvertAll(entrada, int.Parse);
        foreach(int i in valoresInteiros)
        {
            if (i == chaCerto)
            {
                ++soma;
            }
        }
        Console.WriteLine(soma);

    }

}