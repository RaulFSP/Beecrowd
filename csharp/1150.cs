using System; 

class URI {

    static void Main(string[] args) { 

        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        while (x >= y)
        {
            y = int.Parse(Console.ReadLine());
        }
        int cont = 0, soma = 0;
        for(int i = x; i < y; i++)
        {
            soma+=i;
            cont++;
            if (soma > y)
            {
                break;
            }
        }
        Console.WriteLine($"{cont}");

    }

}