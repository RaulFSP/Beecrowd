using System; 

class URI {

    static void Main(string[] args) { 

        int entrada = int.Parse(Console.ReadLine());
        int soma = 1;
        for(int i = 1; i <= entrada; ++i)
        {
            soma*=i;
        }
        Console.WriteLine(soma);

    }

}