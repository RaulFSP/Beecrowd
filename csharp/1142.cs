using System; 

class URI {

    static void Main(string[] args) { 

        int cont = 0;
        int entrada = int.Parse(Console.ReadLine());
        for(int i = 1; i <= entrada; ++i)
        {
            for(int j = 0; j < 1; ++j)
            {
                Console.Write($"{cont+1} {cont+2} {cont+3} {"PUM"}\n");
            }
            cont+=4;
        }

    }

}