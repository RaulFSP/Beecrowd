using System; 

class URI {

    static void Main(string[] args) { 

        int entrada = int.Parse(Console.ReadLine());
        int contador = 0;
        for(int i = 3; i <= entrada; ++i)
        {
            ++contador;
        }
        Console.WriteLine(contador);

    }

}