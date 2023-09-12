using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada = Console.ReadLine().Split(' ');
        int[] numeros = Array.ConvertAll(entrada, int.Parse);
        int a = numeros[0], b = numeros[1];
        if(b%a==0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else if(a%b==0)
        {
            Console.WriteLine("Sao Multiplos");
        }
        else
        {
            Console.WriteLine("Nao sao Multiplos");
        }
    }

}