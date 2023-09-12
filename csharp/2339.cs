using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada = Console.ReadLine().Split(' ');
        int[] valores = Array.ConvertAll(entrada, int.Parse);
        int
        competidores = valores[0],
        qtdPapel = valores[1],
        divisao = valores[2],
        utilizados = competidores*divisao;
        if (utilizados <= qtdPapel)
        {
            Console.WriteLine("S");
        }
        else
        {
            Console.WriteLine("N");
        }
    }

}