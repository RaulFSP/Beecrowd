using System; 

class URI {

    static void Main(string[] args) { 

        string[] entrada = Console.ReadLine().Split(' ');
        int 
        h1 = int.Parse(entrada[0]),
        m1 = int.Parse(entrada[1]),
        h2 = int.Parse(entrada[2]),
        m2 = int.Parse(entrada[3]),
        totalInicial = (h1*60)+m1,
        totalFinal = (h2*60)+m2,
        horas = 0,
        minutos = 0,
        resultado = 0;
        if (totalInicial < totalFinal)
        {
            resultado = totalFinal - totalInicial;
            horas = resultado/60;
            minutos = resultado%60;
            Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
        }
        else if (totalInicial > totalFinal)
        {
            resultado = (1440-totalInicial) + totalFinal;
            horas = resultado/60;
            minutos = resultado%60;
            Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
        }
        else
        {
            Console.WriteLine($"O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)");
        }

    }

}