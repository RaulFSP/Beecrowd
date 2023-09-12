using System; 

class URI {

    static void Main(string[] args) { 

        int entrada, resultado = 0;
        int.TryParse(Console.ReadLine(), out entrada);
        for(int i = 1; i <= 10; ++i)
        {
            resultado = entrada * i;
            Console.WriteLine($"{i} x {entrada} = {resultado}");
        }

    }

}