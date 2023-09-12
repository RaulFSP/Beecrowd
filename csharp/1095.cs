using System; 

class URI {

    static void Main(string[] args) { 

        int n1 = 1, n2 = 60;
        for(int i = 0; i < 13; ++i)
        {
            for(int j = 0; j < 1; ++j)
            {
                Console.Write($"I={n1} J={n2}\n");
            }
            n1+=3;
            n2-=5;
        }

    }

}