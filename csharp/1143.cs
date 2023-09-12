using System; 

class URI {

    static void Main(string[] args) { 

        int entrada = int.Parse(Console.ReadLine());
        for(int i = 1; i <= entrada; ++i)
        {
            for(int j = 0; j < 1; ++j)
            {
                Console.Write($"{i} {Math.Pow(i,2)} {Math.Pow(i,3)}\n");
            }                
        }

    }

}