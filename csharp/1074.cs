using System; 

class URI {

    static void Main(string[] args) { 

        int
        entrada,
        x;
        string
        sinal = "", parImp = "" ;
        int.TryParse(Console.ReadLine(), out entrada);
        do
        {
            int.TryParse(Console.ReadLine(), out x);
            if (x == 0)
            {
                Console.WriteLine("NULL");
            }    
            else
            {
                if(x > 0)
                {
                    sinal = "POSITIVE";
                }
                else
                {
                    sinal = "NEGATIVE";
                }
                if (x%2==0)
                {
                    parImp = "EVEN";
                }
                else
                {
                    parImp = "ODD";
                }
                Console.WriteLine($"{parImp} {sinal}");
            }
            --entrada;
        } while (entrada > 0);

    }

}