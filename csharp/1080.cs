using System; 

class URI {

    static void Main(string[] args) { 

        int 
        entrada,
        maior = 0,
        contador = 1,
        index = 0;
        do
        {
            int.TryParse(Console.ReadLine(), out entrada);
            if (entrada > maior)
            {
                maior = entrada;
                index = contador;
            }
            ++contador;
        } while (contador <= 100);
        Console.WriteLine(maior);
        Console.WriteLine(index);

    }

}