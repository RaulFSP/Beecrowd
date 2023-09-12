using System; 

class URI {

    static void Main(string[] args) { 

        int reps = int.Parse(Console.ReadLine());
        int somaC = 0, somaR = 0, somaS = 0;
        double perC = 0, perR = 0, perS = 0, somaTotal;
        do
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int numeros = int.Parse(entrada[0]);
            char letra = char.Parse(entrada[1]);
            if (letra == 'C')
            {
                somaC += numeros;
            }
            else if (letra == 'R')
            {
                somaR += numeros;
            }
            else
            {
                somaS += numeros;
            }
            --reps;
        } while (reps > 0);
        somaTotal = somaC + somaR + somaS;
        perC = (somaC / somaTotal)*100;
        perR = (somaR / somaTotal)*100;
        perS = (somaS / somaTotal)*100;
        Console.WriteLine($"Total: {somaTotal:F0} cobaias");
        Console.WriteLine($"Total de coelhos: {somaC}");
        Console.WriteLine($"Total de ratos: {somaR}");
        Console.WriteLine($"Total de sapos: {somaS}");
        Console.WriteLine($"Percentual de coelhos: {perC:F2} %");
        Console.WriteLine($"Percentual de ratos: {perR:F2} %");
        Console.WriteLine($"Percentual de sapos: {perS:F2} %");

    }

}