using System; 

class URI {

    static void Main(string[] args) { 

        int entrada = int.Parse(Console.ReadLine());
        for(int i = 1; i <= entrada; ++i)
        {
            for(int j = 1; j < 2; ++j)
            {
                Console.Write($"{i} {Math.Pow(i,2)} {Math.Pow(i,3)}\n");                    
            }
            for(int j = 1; j < 2; ++j)
            {
                Console.Write($"{i} {Math.Pow(i,2)+1} {Math.Pow(i,3)+1}\n");                    
            }
        }

    }

}