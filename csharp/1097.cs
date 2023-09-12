using System; 

class URI {

    static void Main(string[] args) { 

        int min = 5, max = 7;
        for(int i = 1; i <=9; i+=2)
        {
            for(int j = max; j >= min; --j)
            {
                Console.WriteLine($"I={i} J={j}");
            }
            max+=2;
            min+=2;
        }

    }

}