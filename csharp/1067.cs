using System; 

class URI {

    static void Main(string[] args) { 

        int entrada;
        int.TryParse(Console.ReadLine(), out entrada);
        for(int i = 1; i <= entrada; ++i)
        {
            if(i%2 != 0)
            {
                Console.WriteLine(i);
            }
        }

    }

}